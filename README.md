# ClipboardHistory

A basic Clipboard History application written in Visual Basic.

Initionally written for use on machines running Windows 8 or old builds of Windows 10
that do not have this right-out-of-the-box. 

Features update checking capabilities and the ability to bring up a selector / configuration window via a global hotkey.

## Limitations

- Limited to Text.

- Limited to German Language (not localized, may or may not be added eventually).

- Some combinations for the hotkey may not work.

## Operation

- Middle Click on the Tray Icon to paste the last entry.

- Left Click on the Tray Icon to open the main window.

- Right Click on the Tray Icon for a context menu as usual.

- Left Click or ENTER on a recent clipboard entry to try and paste it in the next window in the Alt-Tab Stack.
  If it fails at this the selected entry will still be put to the Clipboard and can be pasted manually.
  
- Right Click or DEL on a recent clipboard entry to remove it from the list. This will not touch the System-Clipboard however.
