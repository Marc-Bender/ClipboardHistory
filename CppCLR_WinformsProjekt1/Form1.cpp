#include "stdafx.h"
#include "Form1.h"

#include <stdio.h>

using namespace CppCLR_WinformsProjekt;

success_t writeDefaultSettings(void)
{
	FILE * fp = fopen("clipboardHistory.settings", "wb");
	if (fp != NULL)
	{
		// file created
		settings_t settings;
		memset(&settings, 0, sizeof(settings_t));
		settings.keyIndex = 1;
		settings.delayTime = 500;
		fwrite(&settings, sizeof(settings_t), 1, fp);
		fclose(fp);
		return true;
	}
	else
	{
		return false;
	}
}

success_t readSettings(settings_t * const readSettings)
{
	FILE * fp = fopen("clipboardHistory.settings", "rb");
	
	memset(readSettings, 0, sizeof(settings_t));
	readSettings->keyIndex = 1;
	readSettings->delayTime = 500;

	if (fp != NULL)
	{
		// file exists and can be opened for reading
		fread(readSettings, sizeof(settings_t), 1, fp);
		fclose(fp);	
		return false;
	}
	return false;
}

void Main_Form::applySettings(const settings_t * const settings)
{
	alwaysAtFront->Checked = settings->topmost;
	autoHide->Checked = settings->autohide;
	acceptVimKeys->Checked = settings->vimKeys;
	openOnActiveMonitor->Checked = settings->currentMonitor;
	hotkeyCTRL->Checked = settings->ctrl;
	hotkeySHIFT->Checked = settings->shift;
	hotkeyALT->Checked = settings->alt;
	hotkeyWIN->Checked = settings->win;
	hotkeyKey->SelectedIndex = settings->keyIndex;
	delayTimeValue->Value = settings->delayTime;
}

void FillHotkeyKey(System::Windows::Forms::ComboBox^ const hotkeyKey)
{
	hotkeyKey->Items->Add("A");
	hotkeyKey->Items->Add("B");
	hotkeyKey->Items->Add("C");
	hotkeyKey->Items->Add("D");
	hotkeyKey->Items->Add("E");
	hotkeyKey->Items->Add("F");
	hotkeyKey->Items->Add("G");
	hotkeyKey->Items->Add("H");
	hotkeyKey->Items->Add("I");
	hotkeyKey->Items->Add("J");
	hotkeyKey->Items->Add("K");
	hotkeyKey->Items->Add("L");
	hotkeyKey->Items->Add("M");
	hotkeyKey->Items->Add("N");
	hotkeyKey->Items->Add("O");
	hotkeyKey->Items->Add("P");
	hotkeyKey->Items->Add("Q");
	hotkeyKey->Items->Add("R");
	hotkeyKey->Items->Add("S");
	hotkeyKey->Items->Add("T");
	hotkeyKey->Items->Add("U");
	hotkeyKey->Items->Add("V");
	hotkeyKey->Items->Add("W");
	hotkeyKey->Items->Add("X");
	hotkeyKey->Items->Add("Y");
	hotkeyKey->Items->Add("Z");

	hotkeyKey->Items->Add("0");
	hotkeyKey->Items->Add("1");
	hotkeyKey->Items->Add("2");
	hotkeyKey->Items->Add("3");
	hotkeyKey->Items->Add("4");
	hotkeyKey->Items->Add("5");
	hotkeyKey->Items->Add("6");
	hotkeyKey->Items->Add("7");
	hotkeyKey->Items->Add("8");
	hotkeyKey->Items->Add("9");

	hotkeyKey->Items->Add("Delete");
	hotkeyKey->Items->Add("Enter");
	hotkeyKey->Items->Add("Back");
	hotkeyKey->Items->Add("Space");

	hotkeyKey->Items->Add("F1");
	hotkeyKey->Items->Add("F2");
	hotkeyKey->Items->Add("F3");
	hotkeyKey->Items->Add("F4");
	hotkeyKey->Items->Add("F5");
	hotkeyKey->Items->Add("F6");
	hotkeyKey->Items->Add("F7");
	hotkeyKey->Items->Add("F8");
	hotkeyKey->Items->Add("F9");
	hotkeyKey->Items->Add("F10");
	hotkeyKey->Items->Add("F11");
	hotkeyKey->Items->Add("F12");
}

System::Void Main_Form::timer1_Tick(System::Object^  sender, System::EventArgs^  e)
{
	if (true == Clipboard::ContainsText())
	{
		String^ const clipboardContents = Clipboard::GetText();
		for (UINT16 i=0;i<recentClipboardEntries->Items->Count; i++)
		{
			if (recentClipboardEntries->Items[i]->Equals(clipboardContents) == true)
			{
				recentClipboardEntries->Items->RemoveAt(i);
			}
		}
		recentClipboardEntries->Items->Insert(0, clipboardContents);
	}
}

System::Void Main_Form::clearHistory_Click(System::Object^  sender, System::EventArgs^  e)
{
	recentClipboardEntries->Items->Clear();
}

System::Void Main_Form::clearClipboard_Click(System::Object^  sender, System::EventArgs^  e)
{
	Clipboard::Clear();
}

Main_Form::Main_Form(void)
{
	InitializeComponent();
	FillHotkeyKey(hotkeyKey);
	settings_t settings;
	if(true == readSettings(&settings))
	{
		applySettings(&settings);
	}
	else
	{
		// file does not exist or can not be opened for reading
		writeDefaultSettings();
	}
}
Main_Form::~Main_Form()
{
	if (components)
	{
		delete components;
	}
}