#pragma once

namespace CppCLR_WinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	
	using success_t = bool;
	
	typedef struct
	{
		UINT16 topmost : 1;
		UINT16 autohide : 1;
		UINT16 vimKeys : 1;
		UINT16 currentMonitor : 1;
		UINT16 ctrl : 1;
		UINT16 shift : 1;
		UINT16 alt : 1;
		UINT16 win : 1;
		UINT16 : 8;
		UINT16 keyIndex;
		UINT16 delayTime;
	} settings_t;

	public ref class Main_Form : public System::Windows::Forms::Form
	{
	public:
		Main_Form(void);
	protected:
		~Main_Form();
	private:
		void applySettings(const settings_t * const settings);
		System::Windows::Forms::Label^  delayTimeLabel;
		System::Windows::Forms::ListBox^  recentClipboardEntries;
		System::Windows::Forms::Button^  clearHistory;
		System::Windows::Forms::Button^  clearClipboard;
		System::Windows::Forms::CheckBox^  alwaysAtFront;
		System::Windows::Forms::CheckBox^  hotkeyCTRL;
		System::Windows::Forms::CheckBox^  hotkeySHIFT;
		System::Windows::Forms::CheckBox^  hotkeyALT;
		System::Windows::Forms::CheckBox^  hotkeyWIN;
		System::Windows::Forms::CheckBox^  autoHide;
		System::Windows::Forms::ComboBox^  hotkeyKey;
		System::Windows::Forms::Button^  changeHotkey;
		System::Windows::Forms::NumericUpDown^  delayTimeValue;
		System::Windows::Forms::Label^  versionNumber;
		System::Windows::Forms::LinkLabel^  checkUpdatesLink;
		System::Windows::Forms::CheckBox^  acceptVimKeys;
		System::Windows::Forms::CheckBox^  openOnActiveMonitor;
	private: System::Windows::Forms::Timer^  timer1;
	private: System::ComponentModel::IContainer^  components;


#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->delayTimeLabel = (gcnew System::Windows::Forms::Label());
			this->recentClipboardEntries = (gcnew System::Windows::Forms::ListBox());
			this->clearHistory = (gcnew System::Windows::Forms::Button());
			this->clearClipboard = (gcnew System::Windows::Forms::Button());
			this->alwaysAtFront = (gcnew System::Windows::Forms::CheckBox());
			this->hotkeyCTRL = (gcnew System::Windows::Forms::CheckBox());
			this->hotkeySHIFT = (gcnew System::Windows::Forms::CheckBox());
			this->hotkeyALT = (gcnew System::Windows::Forms::CheckBox());
			this->hotkeyWIN = (gcnew System::Windows::Forms::CheckBox());
			this->autoHide = (gcnew System::Windows::Forms::CheckBox());
			this->hotkeyKey = (gcnew System::Windows::Forms::ComboBox());
			this->changeHotkey = (gcnew System::Windows::Forms::Button());
			this->delayTimeValue = (gcnew System::Windows::Forms::NumericUpDown());
			this->versionNumber = (gcnew System::Windows::Forms::Label());
			this->checkUpdatesLink = (gcnew System::Windows::Forms::LinkLabel());
			this->acceptVimKeys = (gcnew System::Windows::Forms::CheckBox());
			this->openOnActiveMonitor = (gcnew System::Windows::Forms::CheckBox());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->delayTimeValue))->BeginInit();
			this->SuspendLayout();
			// 
			// delayTimeLabel
			// 
			this->delayTimeLabel->AutoSize = true;
			this->delayTimeLabel->Location = System::Drawing::Point(140, 213);
			this->delayTimeLabel->Name = L"delayTimeLabel";
			this->delayTimeLabel->Size = System::Drawing::Size(89, 13);
			this->delayTimeLabel->TabIndex = 1;
			this->delayTimeLabel->Text = L"Verzögerung [ms]";
			// 
			// recentClipboardEntries
			// 
			this->recentClipboardEntries->FormattingEnabled = true;
			this->recentClipboardEntries->HorizontalScrollbar = true;
			this->recentClipboardEntries->Location = System::Drawing::Point(13, 13);
			this->recentClipboardEntries->Name = L"recentClipboardEntries";
			this->recentClipboardEntries->ScrollAlwaysVisible = true;
			this->recentClipboardEntries->Size = System::Drawing::Size(295, 95);
			this->recentClipboardEntries->TabIndex = 2;
			// 
			// clearHistory
			// 
			this->clearHistory->Location = System::Drawing::Point(12, 115);
			this->clearHistory->Name = L"clearHistory";
			this->clearHistory->Size = System::Drawing::Size(119, 23);
			this->clearHistory->TabIndex = 3;
			this->clearHistory->Text = L"Verlauf leeren";
			this->clearHistory->UseVisualStyleBackColor = true;
			this->clearHistory->Click += gcnew System::EventHandler(this, &Main_Form::clearHistory_Click);
			// 
			// clearClipboard
			// 
			this->clearClipboard->Location = System::Drawing::Point(169, 115);
			this->clearClipboard->Name = L"clearClipboard";
			this->clearClipboard->Size = System::Drawing::Size(139, 23);
			this->clearClipboard->TabIndex = 4;
			this->clearClipboard->Text = L"Zwischenablage leeren";
			this->clearClipboard->UseVisualStyleBackColor = true;
			this->clearClipboard->Click += gcnew System::EventHandler(this, &Main_Form::clearClipboard_Click);
			// 
			// alwaysAtFront
			// 
			this->alwaysAtFront->AutoSize = true;
			this->alwaysAtFront->Location = System::Drawing::Point(12, 144);
			this->alwaysAtFront->Name = L"alwaysAtFront";
			this->alwaysAtFront->Size = System::Drawing::Size(128, 17);
			this->alwaysAtFront->TabIndex = 5;
			this->alwaysAtFront->Text = L"Immer im Vordergrund";
			this->alwaysAtFront->UseVisualStyleBackColor = true;
			// 
			// hotkeyCTRL
			// 
			this->hotkeyCTRL->AutoSize = true;
			this->hotkeyCTRL->Location = System::Drawing::Point(12, 184);
			this->hotkeyCTRL->Name = L"hotkeyCTRL";
			this->hotkeyCTRL->Size = System::Drawing::Size(54, 17);
			this->hotkeyCTRL->TabIndex = 6;
			this->hotkeyCTRL->Text = L"CTRL";
			this->hotkeyCTRL->UseVisualStyleBackColor = true;
			// 
			// hotkeySHIFT
			// 
			this->hotkeySHIFT->AutoSize = true;
			this->hotkeySHIFT->Location = System::Drawing::Point(60, 183);
			this->hotkeySHIFT->Name = L"hotkeySHIFT";
			this->hotkeySHIFT->Size = System::Drawing::Size(57, 17);
			this->hotkeySHIFT->TabIndex = 7;
			this->hotkeySHIFT->Text = L"SHIFT";
			this->hotkeySHIFT->UseVisualStyleBackColor = true;
			// 
			// hotkeyALT
			// 
			this->hotkeyALT->AutoSize = true;
			this->hotkeyALT->Location = System::Drawing::Point(114, 183);
			this->hotkeyALT->Name = L"hotkeyALT";
			this->hotkeyALT->Size = System::Drawing::Size(46, 17);
			this->hotkeyALT->TabIndex = 8;
			this->hotkeyALT->Text = L"ALT";
			this->hotkeyALT->UseVisualStyleBackColor = true;
			// 
			// hotkeyWIN
			// 
			this->hotkeyWIN->AutoSize = true;
			this->hotkeyWIN->Location = System::Drawing::Point(157, 183);
			this->hotkeyWIN->Name = L"hotkeyWIN";
			this->hotkeyWIN->Size = System::Drawing::Size(48, 17);
			this->hotkeyWIN->TabIndex = 9;
			this->hotkeyWIN->Text = L"WIN";
			this->hotkeyWIN->UseVisualStyleBackColor = true;
			// 
			// autoHide
			// 
			this->autoHide->AutoSize = true;
			this->autoHide->Location = System::Drawing::Point(169, 145);
			this->autoHide->Name = L"autoHide";
			this->autoHide->Size = System::Drawing::Size(148, 17);
			this->autoHide->TabIndex = 10;
			this->autoHide->Text = L"Automatisch ausblenden\?";
			this->autoHide->UseVisualStyleBackColor = true;
			// 
			// hotkeyKey
			// 
			this->hotkeyKey->FormattingEnabled = true;
			this->hotkeyKey->Location = System::Drawing::Point(230, 179);
			this->hotkeyKey->Name = L"hotkeyKey";
			this->hotkeyKey->Size = System::Drawing::Size(78, 21);
			this->hotkeyKey->TabIndex = 11;
			// 
			// changeHotkey
			// 
			this->changeHotkey->Location = System::Drawing::Point(12, 208);
			this->changeHotkey->Name = L"changeHotkey";
			this->changeHotkey->Size = System::Drawing::Size(105, 23);
			this->changeHotkey->TabIndex = 12;
			this->changeHotkey->Text = L"Hotkey ändern";
			this->changeHotkey->UseVisualStyleBackColor = true;
			// 
			// delayTimeValue
			// 
			this->delayTimeValue->Location = System::Drawing::Point(230, 208);
			this->delayTimeValue->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1000, 0, 0, 0 });
			this->delayTimeValue->Minimum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 50, 0, 0, 0 });
			this->delayTimeValue->Name = L"delayTimeValue";
			this->delayTimeValue->Size = System::Drawing::Size(78, 20);
			this->delayTimeValue->TabIndex = 13;
			this->delayTimeValue->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 500, 0, 0, 0 });
			// 
			// versionNumber
			// 
			this->versionNumber->AutoSize = true;
			this->versionNumber->Location = System::Drawing::Point(12, 243);
			this->versionNumber->Name = L"versionNumber";
			this->versionNumber->Size = System::Drawing::Size(41, 13);
			this->versionNumber->TabIndex = 14;
			this->versionNumber->Text = L"V.4711";
			// 
			// checkUpdatesLink
			// 
			this->checkUpdatesLink->AutoSize = true;
			this->checkUpdatesLink->Location = System::Drawing::Point(12, 265);
			this->checkUpdatesLink->Name = L"checkUpdatesLink";
			this->checkUpdatesLink->Size = System::Drawing::Size(96, 13);
			this->checkUpdatesLink->TabIndex = 15;
			this->checkUpdatesLink->TabStop = true;
			this->checkUpdatesLink->Text = L"www.example.com";
			// 
			// acceptVimKeys
			// 
			this->acceptVimKeys->AutoSize = true;
			this->acceptVimKeys->Location = System::Drawing::Point(12, 161);
			this->acceptVimKeys->Name = L"acceptVimKeys";
			this->acceptVimKeys->Size = System::Drawing::Size(112, 17);
			this->acceptVimKeys->TabIndex = 16;
			this->acceptVimKeys->Text = L"Accept Vim Keys\?";
			this->acceptVimKeys->UseVisualStyleBackColor = true;
			// 
			// openOnActiveMonitor
			// 
			this->openOnActiveMonitor->AutoSize = true;
			this->openOnActiveMonitor->Location = System::Drawing::Point(137, 160);
			this->openOnActiveMonitor->Name = L"openOnActiveMonitor";
			this->openOnActiveMonitor->Size = System::Drawing::Size(180, 17);
			this->openOnActiveMonitor->TabIndex = 17;
			this->openOnActiveMonitor->Text = L"Auf aktuellem Monitor anzeigen\?";
			this->openOnActiveMonitor->UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this->timer1->Enabled = true;
			this->timer1->Tick += gcnew System::EventHandler(this, &Main_Form::timer1_Tick);
			// 
			// Main_Form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(320, 298);
			this->ControlBox = false;
			this->Controls->Add(this->openOnActiveMonitor);
			this->Controls->Add(this->acceptVimKeys);
			this->Controls->Add(this->checkUpdatesLink);
			this->Controls->Add(this->versionNumber);
			this->Controls->Add(this->delayTimeValue);
			this->Controls->Add(this->changeHotkey);
			this->Controls->Add(this->hotkeyKey);
			this->Controls->Add(this->autoHide);
			this->Controls->Add(this->hotkeyWIN);
			this->Controls->Add(this->hotkeyALT);
			this->Controls->Add(this->hotkeySHIFT);
			this->Controls->Add(this->hotkeyCTRL);
			this->Controls->Add(this->alwaysAtFront);
			this->Controls->Add(this->clearClipboard);
			this->Controls->Add(this->clearHistory);
			this->Controls->Add(this->recentClipboardEntries);
			this->Controls->Add(this->delayTimeLabel);
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"Main_Form";
			this->ShowIcon = false;
			this->Text = L"Clipboard History";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->delayTimeValue))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
			keybd_event(VK_MENU, 0, 0, 0);
			keybd_event(VK_TAB, 0, 0, 0);
			keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0);
			keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);

			System::Threading::Thread::Sleep(100);
			
			const byte VK_LETTER_V = 0x56;
			keybd_event(VK_CONTROL, 0, 0, 0);
			keybd_event(VK_LETTER_V, 0, 0, 0);
			keybd_event(VK_LETTER_V, 0, KEYEVENTF_KEYUP, 0);
			keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
		}
		
		System::Void timer1_Tick(System::Object^  sender, System::EventArgs^  e);
		System::Void clearHistory_Click(System::Object^  sender, System::EventArgs^  e);
		System::Void clearClipboard_Click(System::Object^  sender, System::EventArgs^  e);
};
}
