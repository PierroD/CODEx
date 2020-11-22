
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
<div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="_images/CODEx.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="_images/TCUNV3-1.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="_images/TCUNV3-2.jpg" class="d-block w-100" alt="...">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

## CODEx
Is a **C**all **o**f **D**uty **Ex**ternal Console, after several months of work I decided to release it as open source, if you want to learn a bit more about CODEx you can read it's history [here](./_readmes/CODExHistory.md) 

## Table of contents

- [Quick start](#tc1)
- [Q&A](./_readmes/CODExQA.md)
- [What's included](#tc2)
- [Documentation](#tc3)
- [Creator](#tc4)
- [Thanks](#tc5)

## Quick start <a name="tc1"></a>

- [Download the lastest version](https://raw.githubusercontent.com/PierroD/CODEx/main/_updates/CODEx%20v1.0.zip) - some updates might be needed
- Unzip the archive somehere on your computer
- Start CODEx.exe
- Enjoy :smiley:


## What's included <a name="tc2"></a>

Within the download you'll find the following directories and files, logically grouping common assets and providing both compiled and minified variations. You'll see something like this:
```
.
└───CODEx
    │   CODEx.exe (CODEx's application)
    │   CODEX.exe.config
    │   CODEX.pdb
    │   CODEXOffsets.dll
    │   CODExUpdater.exe (CODEx Updater)
    │   CODEXUpdater.exe.config
    │   CODEXUpdater.pdb
    │   config.ini
    │   Guna.UI.dll
    │   K4os.Compression.LZ4.dll
    │   K4os.Compression.LZ4.xml
    │   K4os.Hash.xxHash.dll
    │   K4os.Hash.xxHash.xml
    │   Newtonsoft.Json.dll
    │   Newtonsoft.Json.xml
    │   System.Buffers.dll
    │   System.Buffers.xml
    │   System.Memory.dll
    │   System.Memory.xml
    │   System.Numerics.Vectors.dll
    │   System.Numerics.Vectors.xml
    │   System.Runtime.CompilerServices.Unsafe.dll
    │   System.Runtime.CompilerServices.Unsafe.xml
    │
    └───DVARList (All the DVAR List you can edit)
        ├───BO2
        │       allDvar.json
        │
        ├───MW2
        │       allDvar.json
        │
        └───MW3
                allDvar.json
```

## Documentation <a name="tc3"></a>

CODEx has been designed to be personalized according to your needs.

- To get CODEx on your desktop you can create a shortcut (in the **Settings** tab)
- CODEx can detect automatically which Call of Duty Multiplayer game is running (MW2, MW3, BO2)
- You can choose were your personnal configs will be saved (by default they will be saved in your `Documents`)
- You can add a macro to the config, so you will be able to call it in-game
- You can search in a customizable DVAR list, all Call of Duty DVAR
- You can copy a DVAR to the clipboard by simply press the copy button
- You can edit these DVAR list, by editing the .json file like the following example
```json
[
 ...
  {
    "Content": "cg_fov 65",
    "Description": "The field of view angle in degrees"
  },
  ...
]

```
:warning: Loading to much DVAR will slow down CODEx due to the UI thread doing his job :smiley:

## Creator <a name="tc4"></a>

Coder & Designer :
- Pierre DUVEAU aka LINDRA

## Thanks <a name="tc5"></a>

Josh aka GRIIM (helping me for the ExternalConsole class)
- https://twitter.com/GRIIMtB

Jim aka Gmzorz (for a part of the DVAR)
- http://gmzorz.weebly.com/
- https://twitter.com/Gmzorz

Team A (Amyst, AUTH, Airyz, A1mini, Ark) (for the idea)

- http://airyz.xyz/bo2-streams.html
 - (Amyst) https://twitter.com/Amyst_Edits
 - (Airyz) https://twitter.com/Airyz_
