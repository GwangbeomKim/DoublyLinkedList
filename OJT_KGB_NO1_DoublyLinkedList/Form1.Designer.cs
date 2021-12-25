
namespace OJT_KGB_NO1_DoublyLinkedList
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Next = new ePOSOne.btnProduct.Button_WOC();
            this.button_Reverse = new ePOSOne.btnProduct.Button_WOC();
            this.button_Pre = new ePOSOne.btnProduct.Button_WOC();
            this.button_Save = new ePOSOne.btnProduct.Button_WOC();
            this.button_Load = new ePOSOne.btnProduct.Button_WOC();
            this.label_Path = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label_Path);
            this.panel1.Controls.Add(this.listView);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.button_Next);
            this.panel1.Controls.Add(this.button_Reverse);
            this.panel1.Controls.Add(this.button_Pre);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Load);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 746);
            this.panel1.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(612, 52);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(347, 484);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(265, 214);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(82, 31);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Name";
            // 
            // button_Next
            // 
            this.button_Next.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Next.ButtonColor = System.Drawing.Color.DimGray;
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button_Next.Location = new System.Drawing.Point(238, 384);
            this.button_Next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Next.Name = "button_Next";
            this.button_Next.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_Next.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_Next.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Next.Size = new System.Drawing.Size(126, 50);
            this.button_Next.TabIndex = 6;
            this.button_Next.Text = "Next";
            this.button_Next.TextColor = System.Drawing.Color.White;
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Reverse
            // 
            this.button_Reverse.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Reverse.ButtonColor = System.Drawing.Color.DimGray;
            this.button_Reverse.FlatAppearance.BorderSize = 0;
            this.button_Reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reverse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reverse.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button_Reverse.Location = new System.Drawing.Point(383, 384);
            this.button_Reverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Reverse.Name = "button_Reverse";
            this.button_Reverse.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_Reverse.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_Reverse.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Reverse.Size = new System.Drawing.Size(126, 50);
            this.button_Reverse.TabIndex = 5;
            this.button_Reverse.Text = "Reverse";
            this.button_Reverse.TextColor = System.Drawing.Color.White;
            this.button_Reverse.UseVisualStyleBackColor = true;
            this.button_Reverse.Click += new System.EventHandler(this.button_Reverse_Click);
            // 
            // button_Pre
            // 
            this.button_Pre.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Pre.ButtonColor = System.Drawing.Color.DimGray;
            this.button_Pre.FlatAppearance.BorderSize = 0;
            this.button_Pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pre.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button_Pre.Location = new System.Drawing.Point(93, 384);
            this.button_Pre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Pre.Name = "button_Pre";
            this.button_Pre.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_Pre.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_Pre.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Pre.Size = new System.Drawing.Size(126, 50);
            this.button_Pre.TabIndex = 4;
            this.button_Pre.Text = "Previous";
            this.button_Pre.TextColor = System.Drawing.Color.White;
            this.button_Pre.UseVisualStyleBackColor = true;
            this.button_Pre.Click += new System.EventHandler(this.button_Pre_Click);
            // 
            // button_Save
            // 
            this.button_Save.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Save.ButtonColor = System.Drawing.Color.DimGray;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button_Save.Location = new System.Drawing.Point(793, 559);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_Save.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_Save.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Save.Size = new System.Drawing.Size(126, 50);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.TextColor = System.Drawing.Color.White;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Load.ButtonColor = System.Drawing.Color.DimGray;
            this.button_Load.FlatAppearance.BorderSize = 0;
            this.button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Load.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.button_Load.Location = new System.Drawing.Point(639, 559);
            this.button_Load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Load.Name = "button_Load";
            this.button_Load.OnHoverBorderColor = System.Drawing.Color.White;
            this.button_Load.OnHoverButtonColor = System.Drawing.Color.DarkSeaGreen;
            this.button_Load.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Load.Size = new System.Drawing.Size(126, 50);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Load";
            this.button_Load.TextColor = System.Drawing.Color.White;
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_Path.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Path.Location = new System.Drawing.Point(234, 503);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(0, 22);
            this.label_Path.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 750);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_Load;
        private ePOSOne.btnProduct.Button_WOC button_Save;
        private System.Windows.Forms.Label label_Name;
        private ePOSOne.btnProduct.Button_WOC button_Next;
        private ePOSOne.btnProduct.Button_WOC button_Reverse;
        private ePOSOne.btnProduct.Button_WOC button_Pre;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label_Path;
    }
}

