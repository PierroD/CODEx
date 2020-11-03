using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEXOffsets;

namespace CODEX.Utils
{
    public class ExternalConsole
    {
        #region DLLImports
        [DllImport("kernel32")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, [Out] int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, [Out] int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);
        #endregion

        #region Variable Declarations
        private static byte[] WrapperTocBuf_AddText = new byte[] {
            0x55, 0x8b, 0xec, 0x83, 0xec, 8, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xc7, 0x45, 0xfc,
            0, 0, 0, 0, 0xff, 0x75, 0xf8, 0x6a, 0, 0xff, 0x55, 0xfc, 0x83, 0xc4, 8, 0x8b,
            0xe5, 0x5d, 0xc3
    };
        private static byte[] WrapperSendToServer = new byte[]
        {
            0x55, 0x8b, 0xec, 0x83, 0xec, 8, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xc7, 0x45, 0xfc,
            0, 0, 0, 0, 0xff, 0x75, 0xf8, 0x6a, 0, 0x6a, 0, 0xff, 0x55, 0xfc, 0x83, 0xc4,
            8, 0x8b, 0xe5, 0x5d, 0xc3
        };
        private static IntPtr _cBuf_addTextFuncAddress = IntPtr.Zero;
        private static IntPtr _SV_GameSendServercmdAddress = IntPtr.Zero;
        private static byte[] callBytes;
        private static IntPtr cmdAddress = IntPtr.Zero;
        private static byte[] cmdBytes;
        private static IntPtr ProcessHandle = IntPtr.Zero;
        private static int ProcessID = -1;
        #endregion

        public static void Send(string cmd)
        {

            try
            {
                if (COD.checkGame())
                {
                    dynamic cod = COD.Game();
                    callBytes = BitConverter.GetBytes(cod.GetType().GetProperty("cbuf_addtext").GetValue(cod));
                    Process[] procbyName = Process.GetProcessesByName(COD.GameName());
                    ProcessID = procbyName[0].Id;
                    ProcessHandle = OpenProcess(0x1f0fff, false, ProcessID);

                }
                if (cmd == String.Empty)
                {
                    MessageBox.Show("Please type in a command before pressing Send button", "Error", MessageBoxButtons.OK);
                }

                if (_cBuf_addTextFuncAddress == IntPtr.Zero)
                {
                    IntPtr ptr;
                    _cBuf_addTextFuncAddress = VirtualAllocEx(ProcessHandle, IntPtr.Zero, (uint)WrapperTocBuf_AddText.Length, 0x3000, 0x40);
                    cmdBytes = Encoding.ASCII.GetBytes(cmd + '\0');
                    cmdAddress = VirtualAllocEx(ProcessHandle, IntPtr.Zero, (uint)cmdBytes.Length, 0x3000, 0x40);
                    WriteProcessMemory(ProcessHandle, cmdAddress, cmdBytes, (uint)cmdBytes.Length, 0);
                    Array.Copy(BitConverter.GetBytes(cmdAddress.ToInt32()), 0, WrapperTocBuf_AddText, 9, 4);
                    Array.Copy(callBytes, 0, WrapperTocBuf_AddText, 0x10, 4);
                    WriteProcessMemory(ProcessHandle, _cBuf_addTextFuncAddress, WrapperTocBuf_AddText, (uint)WrapperTocBuf_AddText.Length, 0);
                    CreateRemoteThread(ProcessHandle, IntPtr.Zero, 0, _cBuf_addTextFuncAddress, IntPtr.Zero, 0, out ptr);
                    if ((_cBuf_addTextFuncAddress != IntPtr.Zero) && (cmdAddress != IntPtr.Zero))
                    {
                        VirtualFreeEx(ProcessHandle, _cBuf_addTextFuncAddress, (UIntPtr)WrapperTocBuf_AddText.Length, 0x8000);
                        VirtualFreeEx(ProcessHandle, cmdAddress, (UIntPtr)cmdBytes.Length, 0x8000);
                    }
                    _cBuf_addTextFuncAddress = IntPtr.Zero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
    }
}
