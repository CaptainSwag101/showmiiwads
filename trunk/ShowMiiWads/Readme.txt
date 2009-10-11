ShowMiiWads is a 'WAD File Manager' for Windows.
It is licensed under the terms of the GNU General Public License v2
The .NET-Framework 2.0 is required to run this application!
The (Common-)Key.bin is required for full functionality (Can be created using Tools -> Create Common-Key)

For further information or if you have suggestions, found bugs or anything else,
visit: http://showmiiwads.googlecode.com/
You can simply translate the application by editing the example.slang, if you
want to have your translation included into the application, contact me..

-----------------------------------------------------------------------------------------
Changelog:

Version 1.0
	- Finally got independant of external tools (saves about 3 MB)
	  All reading, editing and writing of wad and related files is now done by my own classes!
	- (common-)key.bin must now be in the application directory
	- Added ShowMiiNand (will show all installed titles on your NAND Backup)
	- Installed Titles can be packed to a Wad (ShowMiiNand)
	- Installation Queue for ShowMiiNand (drag wad files or folders onto the list and they
	  will be queued, click install to extract them to the NAND Backup)
	- Better type detection (IOS, SysMenu, Hidden Channel, ... Unfortunately, VC / WiiWare
	  detection returns official channel to be VC / WiiWare, so it's turned off)
	- Channel Title will be displayed depending on your language (only for embedded languages)
	- Option to add all subfolders (e.g. add C:\Wads and C:\Wads\Channel + C:\Wads\IOS + ... will be added)
	- Shared contents will now be copied (if not exist) to Nand Backup (Extract To Nand)
	- Preview of Banner and Icon (only pics, no animation of course)
	  (Some Images will be like empty, could be unsupported format (few) or they are just empty (most))
	- Added Tools Menu (Pack Wads, Unpack U8, Convert TPL, Create Common-Key)
	- Added Option to create Backups before editing
	- French translation added (Thanks to carbonyle)
	- Added Update Check (yet only checks, but doesn't download)
	- Bugfixes and small changes

Version 0.3
	- From-to sizes / blocks for big Wads (it was minimum size before)
	- System Titles will be shown (IOS / System Menu)
	- New columns for Type (Channel / System), Channel Title and Version
	- Extract Wads to NAND Backup (Only important files, for use with TriiForce / NAND Emulation)
	- Extract Wads to Folder (All files)
	- Added some shortcuts
	- External language files can be loaded (see example.slang)
	- Fixed a bug with the filecount label (raised with every refresh)
	- Batch changing to Region Free (all Wads in a folder)
	- Option to show either foldername or full path in groupheader
	- Export list to file (txt and csv, same file with different extension)
	- Added 'Recently Opened' folders menu
    - Changing of Channel Title (Displayed when holding cursor over a channel on wii)
	  -> You can also see the title for other languages by clicking
	     'Change Channel Title'. Only the english title is displayed in the column.

Version 0.2
	- Rewrote some code, so .NET Framework 3.5 isn't needed anymore
	- Better errorhandling, invalid Wads won't be shown anymore
	- Possibility to change Title IDs
	- Possibility to change Region Flags (using freethewads.exe)
	- WadDataInfo.exe isn't needed separately anymore, it's embedded
	- Multiple folder support
	- Drag & Drop support (single or multiple files/folders)
	- Copy / Move files between folders
	- Windowsize and -location is saved
	- Some little things
	
Version 0.1b
	- Little bugfix

Version 0.1
	- List all Wad files of a specified folder
	- Rename Wad files
	- Delete Wad files
	- Multilanguage (English + German)
	- .NET Framework 3.5 needed for full funcionality
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
Disclaimer:

Editing WAD files can result in a brick of your Wii.
Only use these features if you have a bricksafe Wii, meaning either Preloader or
BootMii/boot2 is installed, and if you know what you're doing.
Also, your Wad files could be destroyed, so be sure to have a backup.

This application comes without any express or implied warranty.
The author can't be held responsible for any damages arising from the use of it.
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
Thanks:

icefire / Xuzz for Wii.py (which was the base for TPL conversion)
SquidMan for Zetsubou (which was a reference for TPL conversion)
Andre Perrot for gbalzss (which was the base for LZ77 decompression)
NeoRame for the Logo
Blitzur for Betatesting
kedest for Betatesting
nutta_nic for Betatesting
Dteyn for Betatesting
acesniper for Betatesting
carbonyle for French translation
Everyone for using this application
-----------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------
License:

Copyright (C) 2009 Leathl

ShowMiiWads is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.
 
ShowMiiWads is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
-----------------------------------------------------------------------------------------