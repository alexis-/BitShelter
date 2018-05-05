## BitShelter

*BitShelter* is software that builds on [Microsoft's VSS technology](https://en.wikipedia.org/wiki/Shadow_Copy) to keep a version history of your files, and make external backups of them.

Have you **deleted** a file by mistake ? Modified a document and wish to **revert** the **changes** ? Has one of your **drive failed** ? *BitShelter* has got you covered is all these cases !

**ATTENTION**: *BitShelter* is a **Work In Progress**, you may encounter bugs and not all features are available yet.

### Table of Content
- [Screenshots](#screenshots)
- [Features](#features)
- [Installation and Usage](#installation-and-usage)
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
- **Snapshots**: Keep a [version history](https://www.howtogeek.com/howto/11130/restore-previous-versions-of-files-in-every-edition-of-windows-7/) of your files
  - Revert file modifications
  - Restore deleted files
  - [Browse your files](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/explorer_2018-05-04_18-00-38.png) as they were at a previous point in time
  - Low space usage using the [Incremental method](https://en.wikipedia.org/wiki/Copy-on-write)
  - Short snapshots intervals have a [negligible cost on space usage](https://en.wikipedia.org/wiki/Copy-on-write)
  - Capture your data even when they are [locked by other Processes](https://msdn.microsoft.com/en-us/library/windows/desktop/aa384612(v=vs.85).aspx)
  - Up to [512 Snapshots](https://msdn.microsoft.com/en-us/library/bb891959.aspx?#maxshadowcopies)
  - Very flexible [scheduling system](https://raw.githubusercontent.com/alexis-/BitShelter/master/Resources/BitShelter.Agent_Schedule.png)
- **[WIP] Backups**: Secure your data on other drives, or off-site (owned machines, on the cloud, ...)
  - Granular filtering of backed-up files with [Glob](https://github.com/dazinator/DotNet.Glob#patterns) and [Regex](https://www.regular-expressions.info/)
  - Archive (.zip, .tar) and compress (deflate, bzip2, lzma) your files
  - Encrypt your files: 3 Protocols ([Simple AES](https://en.wikipedia.org/wiki/Advanced_Encryption_Standard), [PBE](http://www.crypto-it.net/eng/theory/pbe.html), [PGP](https://en.wikipedia.org/wiki/Pretty_Good_Privacy)), Several Algorithms ([AES-CBC/CFC](https://en.wikipedia.org/wiki/Block_cipher_mode_of_operation#Common_modes), [Blowfish](https://en.wikipedia.org/wiki/Blowfish_(cipher)), [Camellia128/258](https://en.wikipedia.org/wiki/Camellia_(cipher)), [Cast5](https://en.wikipedia.org/wiki/CAST-128), [3-DES](https://en.wikipedia.org/wiki/Triple_DES), SHA1/256-Twofish, SHA1/256-3-DES, SHA1/256-AES128/256)
  - **[WIP]** Schedule your backups more finely, based on the *Snapshot*'s schedule
  - **[WIP]** Control the maximum size and rotation of your backups
  - Backup your data even when they are locked by other Processes (see *Snaphots*)

### Limitations

### Installation and Usage

### Best practices

### FAQ

### Glossary

### Special thanks, Credits, Licenses

*BitShelter* is built on the work of people who pledged their time to the Open Source community.

I would like to emphasize on the importance of their contribution, and extend my gratitude especially to (but not limited to):
* *Peter Palotas* for his **incredible** [AlphaVSS](https://github.com/alphaleonis/AlphaVSS) (central piece of *BitShelter*)
* (todo)

All required licenses can be found at the root of this project repository.
If however you found that I omitted to include the terms of the license for one of your work, by all mean please let me know so that I may correct this.
