#pragma once

namespace CppCLR_WinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
		}

	protected:
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private:
		System::Windows::Forms::Button^  button1;
		System::Windows::Forms::Label^  label1;
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			this->button1->Location = System::Drawing::Point(86, 116);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"button1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(13, 13);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 13);
			this->label1->TabIndex = 1;
			this->label1->Text = L"label1";
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 261);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->ResumeLayout(false);
			this->PerformLayout();
		}
#pragma endregion
		System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
			INPUT altDown = 
				{
					INPUT_KEYBOARD,
					{
						/*wVk*/         VK_MENU,
						/*wScan*/       0,
						/*dwFlags*/     0,
						/*time*/        0,
						/*dwExtraInfo*/ 0
					}
				};

			INPUT tabDown =
				{
					INPUT_KEYBOARD,
					{
						/*wVk*/         VK_TAB,
						/*wScan*/       0,
						/*dwFlags*/     0,
						/*time*/        0,
						/*dwExtraInfo*/ NULL
					}
				};

			INPUT tabUp =
				{
					INPUT_KEYBOARD,
					{
						/*wVk*/         VK_TAB,
						/*wScan*/       0,
						/*dwFlags*/     KEYEVENTF_KEYUP,
						/*time*/        0,
						/*dwExtraInfo*/ NULL
					}
				};

			INPUT altUp =
				{
					INPUT_KEYBOARD,
					{
						/*wVk*/         VK_MENU,
						/*wScan*/       0,
						/*dwFlags*/     KEYEVENTF_KEYUP,
						/*time*/        0,
						/*dwExtraInfo*/ NULL
					}
				};

			//SendInput(1, &altDown, sizeof(INPUT));
			//SendInput(1, &tabDown, sizeof(INPUT));
			//SendInput(1, &tabUp, sizeof(INPUT));
			//SendInput(1, &altUp, sizeof(INPUT));
			keybd_event(VK_MENU, 0, 0, 0);
			keybd_event(VK_TAB, 0, 0, 0);
			keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0);
			keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);
			System::Threading::Thread::Sleep(100);
			keybd_event(VK_CONTROL, 0, 0, 0);
			const byte VK_LETTER_V = 0x56;
			keybd_event(VK_LETTER_V, 0, 0, 0);
			keybd_event(VK_LETTER_V, 0, KEYEVENTF_KEYUP, 0);
			keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
		}
	};
}
