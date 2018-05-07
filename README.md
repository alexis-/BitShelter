## BitShelter

*BitShelter* a is software that builds on [Microsoft's VSS technology](https://en.wikipedia.org/wiki/Shadow_Copy) to keep a version history of your files, and make external backups of them.

Have you **deleted** a file by mistake ? Modified a document and wish to **revert** the **changes** ? Has one of your **drive failed** ? *BitShelter* has got you covered in all these cases !

**ATTENTION**: *BitShelter* is a **Work In Progress**, you may encounter bugs and not all features are available yet.

### Table of Content
- [Screenshots](#screenshots)
- [Features](#features)
- [Limitations](#limitations)
- [How does it work ?](#how-does-it-work-)
- [Requirements](#requirements)
- [Downloads](#downloads)
- [Installation and Usage](#installation-and-usage)
- [Upgrading](#upgrading)
- [Best Practices](#best-practices)
- [FAQ](#faq)
- [Glossary](#glossary)
- [Special thanks, Credits, Licenses](#special-thanks-credits-licenses)

### Screenshots

File Version History       |  Rewinding time
:-------------------------:|:-------------------------:
![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_17-50-30.png) | ![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_18-00-38.png)

New rule: General          |  New rule: Schedule
:-------------------------:|:-------------------------:
![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_General.png)  |  ![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Schedule.png)

List of defined Rules      |  New rule: Advanced
:-------------------------:|:-------------------------:
![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Rules.png)  |  ![](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Advanced.png)


### Features

**Snapshots**: Keep a [version history](https://www.howtogeek.com/howto/11130/restore-previous-versions-of-files-in-every-edition-of-windows-7/) of your files
- Revert file modifications
- Restore deleted files
- [Browse your files](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_18-00-38.png) as they were at a previous point in time
- Low space usage using the [Incremental method](https://en.wikipedia.org/wiki/Copy-on-write)
- Short snapshots intervals have a [negligible cost on space usage](https://en.wikipedia.org/wiki/Copy-on-write)
- Capture your data even when they are [locked by other Processes](https://msdn.microsoft.com/en-us/library/windows/desktop/aa384612(v=vs.85).aspx)
- Very flexible [scheduling system](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Schedule.png)

*[WIP]* **Backups**: Secure your data on other drives, or off-site
- Easily integrates with popular Cloud storage providers (Dropbox, GDrive, ...) using their folder syncing feature
- Granular filtering of backed-up files with [Glob](https://github.com/dazinator/DotNet.Glob#patterns) and [Regex](https://www.regular-expressions.info/) patterns
- Archive (.zip, .tar) and compress (deflate, bzip2, lzma) your files
- Encrypt your files: 3 Protocols ([Simple AES](https://en.wikipedia.org/wiki/Advanced_Encryption_Standard), [PBE](http://www.crypto-it.net/eng/theory/pbe.html), [PGP](https://en.wikipedia.org/wiki/Pretty_Good_Privacy)), Several Algorithms ([AES-CBC/CFC](https://en.wikipedia.org/wiki/Block_cipher_mode_of_operation#Common_modes), [Blowfish](https://en.wikipedia.org/wiki/Blowfish_(cipher)), [Camellia128/258](https://en.wikipedia.org/wiki/Camellia_(cipher)), [Cast5](https://en.wikipedia.org/wiki/CAST-128), [3-DES](https://en.wikipedia.org/wiki/Triple_DES), SHA1/256-Twofish, SHA1/256-3-DES, SHA1/256-AES128/256)
- *[WIP]* Schedule your backups more finely, based on the *Snapshot*'s schedule
- *[WIP]* Control the maximum size and rotation of your backups
- Backup your data even when they are locked by other Processes (see *Snaphots*)

### Limitations

- Up to [512 Snapshots](https://msdn.microsoft.com/en-us/library/bb891959.aspx?#maxshadowcopies) per Drive
- Encryption only work when combined with Archives
- [Manual one-time](#installation-and-usage) activation of Windows [System Protection](https://github.com/alexis-/BitShelter/raw/master/Resources/SystemPropertiesProtection_2018-05-05_13-10-18.png) on desired Drives

If you know a work-around for these limitations, please let me know [here](https://github.com/alexis-/BitShelter/issues) or by [email](mailto:alexis@incogito.org)

### How does it work ?

[![](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Banner.png)](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.BannerFull.png)

Operation        |  Result                   |  Location    |  Size        |  Speed
:---------------:|:-------------------------:|:------------:|:------------:|:------------:
**Snapshot**     |  This is *similar* to **Ctrl+Z** for files. Every time a snapshot is created, the system memorizes the content of your files. You can [browse](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_18-00-38.png), [view and restore](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_17-50-30.png) them to earlier versions. You can continue your work without interference during the process<sup>1</sup>   |  Same drive as data  |  As much as the difference between each consecutive snapshot  |  Almost instantaneous
**Backup**       |  This is *similar* to **Ctrl+C** and **Ctrl+V**: Backups create a *copy* of your files. They can be stored locally or remotely. You can optionaly archive them with compression (e.g. zip, tar.gz), and encrypt them. Because Backups operate on Snapshots, you can continue your work without interference during the process<sup>1</sup>. See [best practices](#best-practices) for recommendations  |  Local drive, Network drive, Removable device, ...  |  At most as much as the data, less if compressed  |  Minutes to hours depending on size, disk speed, compression, encryption
**Cloud sync**   |  While *BitShelter* knows nothing about Cloud Storage, you can use backups to create copies of your work in Sync folders of popular providers. They will in turn be sent to your space on the Cloud  |  In the cloud  |  As much as backups, only counting toward your Cloud Storage space  |  Minutes to hours, depending on size, upload speed

**<sup>1</sup>**: When a snapshot is created, existing data aren't copied. Instead, an index of where the data exist is built and new data written to free space. This is extremely fast, and allow to operate on snapshots concurrently with the "live data". For more information, see [Copy-on-write](https://en.wikipedia.org/wiki/Copy-on-write)

### Requirements

- While *BitShelter* should run on any Windows higher or equal to **Vista**, as of now (2018-05-05) it has **only been tested on Windows 10**
- .NET 6.0.1 or higher (installed during Setup)
- Configured Devices in Windows **System Protection** (see [Installation and Usage](#installation-and-usage))

### Downloads

[**All releases**](https://github.com/alexis-/BitShelter/releases)

[**Latest version (installer)**](https://github.com/alexis-/BitShelter/releases/download/0.1b-alpha/BitShelter_v0.1b-alpha_Setup.msi)

![](https://github.com/alexis-/BitShelter/raw/master/Resources/warning_24.png) **Make sure to follow the instructions** about ***System Protection*** and ***Raise limit***, see [Installation and Usage](#installation-and-usage)

### Installation and Usage

1. [Download](#downloads) the latest version, and run the installer
2. Start **BitShelter Agent** from the Windows Start menu
3. Double-click on the [**Tray Icon**](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_TrayIcon.png): ![](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter_Icon.png)
4. In the [Main Window](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Rules.png), click the **Add Schedule** button
    * Click on **Enable other Drive(s)** in the [General tab](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_General.png)
    * Select the required Drives in the [System Protection dialog](https://github.com/alexis-/BitShelter/blob/master/Resources/SystemPropertiesProtection_2018-05-05_13-10-18.png) and click on **Configure**
    * In the [new dialog](https://github.com/alexis-/BitShelter/raw/master/Resources/SystemPropertiesProtection_2018-05-05_13-10-22.png) click on **Turn on protection**, select the desired reserved space for Snapshots, press **OK**
    * Click on **Raise limit** in the [General tab](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_General.png), and set the new limit to **512**
    * Select desired **Drive letters** and **Lifetime** in the [General tab](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_General.png)
    * Set the desired schedule for your Snapshots in the [Schedule tab](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_Schedule.png)
    * Press the **Create** button
    * To make sure your settings are correct, [verify the snapshots](https://www.howtogeek.com/howto/11130/restore-previous-versions-of-files-in-every-edition-of-windows-7/) are properly created on selected Drives

### Upgrading

*BitShelter* cannot Auto-Update itself yet. To upgrade to a newer version, please uninstall the existing application, and run the installer for the new version.

All your settings, snapshots and logs will be preversed.

### Best practices

Rule of thumb: The [3-2-1 Backup Rule](https://www.acronyms-it.co.uk/blog/backup-rule-of-three/) and its [visual guide](https://github.com/alexis-/BitShelter/raw/master/Resources/X35Ndt4et3JGm9GU-GFTa6y6o4OSnUrVKyUh2y5s8_E.png)

For your Local disks:
- Prefer *Redudant Disk Storage*, such as [RAID 1 or 5](https://www.maketecheasier.com/set-up-raid-windows/)
- Use [different Batches, or Brands](https://www.ssrc.ucsc.edu/papers/paris-storagess06.pdf), for your Disks
- Use an *automatic* solution : Set & Forget !
- Ask yourself what would happen if your device failed:
    - Would you presently be able to recover your files ?
    - What data would you lose ?
    - Is it important ?

Here are three introduction guides to Data Safety:

- How to Geek: [What's the best way to back-up my computer ?](https://www.howtogeek.com/242428/whats-the-best-way-to-back-up-my-computer/)
- PCMag: [The Beginner's Guide to PC Backup](https://www.pcmag.com/article2/0,2817,2363057,00.asp)
- MakeUseOf: [Windows 10 data backup guide](https://www.makeuseof.com/tag/ultimate-windows-10-data-backup-guide/)

### FAQ

- *Is VSS safe ?*

I have come across a number of older (2010-2014) posts about issues with VSS, below is an account of them.

According to my own experience, after using *BitShelter* for over a month as of the time of this writing (2018-05-05, Windows 10, Version 1709), I have never experienced any of them ; despite several trials to reproduce these issues, in different environments.

[Snapshot corruption: restored files are damaged](https://answers.microsoft.com/en-us/windows/forum/windows8_1-files/shadow-copy-snapshot-file-contents-silently/06a5e25b-6607-45eb-81a1-71cfc2b0cce3?tm=1431093840771)

- *How to start the Agent at startup ?*

The Service is configured to run at startup, so *BitShelter* will still be active even if the *Agent* is stopped.
If you wish you automatically run *BitShelter Agent* when your computer starts:
1. Run the *Agent*
2. Right-click on its **Tray Icon**
3. Make sure **Run at startup** is Checked.


- *Connection to the service failed*: What to do ?

Please make sure the **BitShelter** [Service is running](http://www.thewindowsclub.com/open-windows-services)

Connection failed          |  BitShelter Service
:-------------------------:|:-------------------------:
![](https://github.com/alexis-/BitShelter/raw/master/Resources/BitShelter.Agent_2018-05-04_22-14-46.png) | ![](https://github.com/alexis-/BitShelter/raw/master/Resources/mmc_2018-05-05_15-03-01.png)

### Glossary

Todo

### Special thanks, Credits, Licenses

*BitShelter* is built on the work of people who pledged their time to the Open Source community.

I would like to emphasize on the importance of their contribution, and extend my gratitude especially to (but not limited to):
* *Peter Palotas* for his **incredible** [AlphaVSS](https://github.com/alphaleonis/AlphaVSS) (central piece of *BitShelter*)
* *Faan* for her **amazing** [banner](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.BannerFull.png). She's open to new opportunities, if you're looking for talented designers please contact me [by email](mailto:alexis@incogito.org) !
* (todo)

All required licenses can be found at the root of this project repository.
If however you found that I omitted to include the terms of the license for one of your work, by all mean please let me know so that I may correct this.
