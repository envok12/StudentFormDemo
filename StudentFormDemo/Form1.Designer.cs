
namespace StudentFormDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.studnetIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.majorGroupBox = new System.Windows.Forms.GroupBox();
            this.programmingRadioButton = new System.Windows.Forms.RadioButton();
            this.webDesignRadioButton = new System.Windows.Forms.RadioButton();
            this.ITRadioButton = new System.Windows.Forms.RadioButton();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.cis101CheckBox = new System.Windows.Forms.CheckBox();
            this.cis102CheckBox = new System.Windows.Forms.CheckBox();
            this.cis103CheckBox = new System.Windows.Forms.CheckBox();
            this.cis104CheckBox = new System.Windows.Forms.CheckBox();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.score101TextBox = new System.Windows.Forms.TextBox();
            this.score102TextBox = new System.Windows.Forms.TextBox();
            this.score103TextBox = new System.Windows.Forms.TextBox();
            this.score104TextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.majorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(80, 34);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(74, 17);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(80, 74);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(80, 116);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // studnetIDTextBox
            // 
            this.studnetIDTextBox.Location = new System.Drawing.Point(195, 34);
            this.studnetIDTextBox.Name = "studnetIDTextBox";
            this.studnetIDTextBox.Size = new System.Drawing.Size(145, 22);
            this.studnetIDTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(195, 73);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(145, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(195, 112);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(145, 22);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // majorGroupBox
            // 
            this.majorGroupBox.Controls.Add(this.ITRadioButton);
            this.majorGroupBox.Controls.Add(this.webDesignRadioButton);
            this.majorGroupBox.Controls.Add(this.programmingRadioButton);
            this.majorGroupBox.Location = new System.Drawing.Point(98, 165);
            this.majorGroupBox.Name = "majorGroupBox";
            this.majorGroupBox.Size = new System.Drawing.Size(137, 130);
            this.majorGroupBox.TabIndex = 6;
            this.majorGroupBox.TabStop = false;
            this.majorGroupBox.Text = "Major";
            // 
            // programmingRadioButton
            // 
            this.programmingRadioButton.AutoSize = true;
            this.programmingRadioButton.Location = new System.Drawing.Point(7, 30);
            this.programmingRadioButton.Name = "programmingRadioButton";
            this.programmingRadioButton.Size = new System.Drawing.Size(113, 21);
            this.programmingRadioButton.TabIndex = 0;
            this.programmingRadioButton.TabStop = true;
            this.programmingRadioButton.Text = "Programming";
            this.programmingRadioButton.UseVisualStyleBackColor = true;
            // 
            // webDesignRadioButton
            // 
            this.webDesignRadioButton.AutoSize = true;
            this.webDesignRadioButton.Location = new System.Drawing.Point(7, 67);
            this.webDesignRadioButton.Name = "webDesignRadioButton";
            this.webDesignRadioButton.Size = new System.Drawing.Size(106, 21);
            this.webDesignRadioButton.TabIndex = 1;
            this.webDesignRadioButton.TabStop = true;
            this.webDesignRadioButton.Text = "Web Design";
            this.webDesignRadioButton.UseVisualStyleBackColor = true;
            // 
            // ITRadioButton
            // 
            this.ITRadioButton.AutoSize = true;
            this.ITRadioButton.Location = new System.Drawing.Point(6, 103);
            this.ITRadioButton.Name = "ITRadioButton";
            this.ITRadioButton.Size = new System.Drawing.Size(41, 21);
            this.ITRadioButton.TabIndex = 2;
            this.ITRadioButton.TabStop = true;
            this.ITRadioButton.Text = "IT";
            this.ITRadioButton.UseVisualStyleBackColor = true;
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Location = new System.Drawing.Point(409, 34);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(60, 17);
            this.coursesLabel.TabIndex = 7;
            this.coursesLabel.Text = "Courses";
            // 
            // cis101CheckBox
            // 
            this.cis101CheckBox.AutoSize = true;
            this.cis101CheckBox.Location = new System.Drawing.Point(412, 74);
            this.cis101CheckBox.Name = "cis101CheckBox";
            this.cis101CheckBox.Size = new System.Drawing.Size(79, 21);
            this.cis101CheckBox.TabIndex = 8;
            this.cis101CheckBox.Text = "CIS 101";
            this.cis101CheckBox.UseVisualStyleBackColor = true;
            this.cis101CheckBox.CheckedChanged += new System.EventHandler(this.cis101CheckBox_CheckedChanged);
            // 
            // cis102CheckBox
            // 
            this.cis102CheckBox.AutoSize = true;
            this.cis102CheckBox.Location = new System.Drawing.Point(412, 120);
            this.cis102CheckBox.Name = "cis102CheckBox";
            this.cis102CheckBox.Size = new System.Drawing.Size(79, 21);
            this.cis102CheckBox.TabIndex = 9;
            this.cis102CheckBox.Text = "CIS 102";
            this.cis102CheckBox.UseVisualStyleBackColor = true;
            this.cis102CheckBox.CheckedChanged += new System.EventHandler(this.cis102CheckBox_CheckedChanged);
            // 
            // cis103CheckBox
            // 
            this.cis103CheckBox.AutoSize = true;
            this.cis103CheckBox.Location = new System.Drawing.Point(412, 166);
            this.cis103CheckBox.Name = "cis103CheckBox";
            this.cis103CheckBox.Size = new System.Drawing.Size(79, 21);
            this.cis103CheckBox.TabIndex = 10;
            this.cis103CheckBox.Text = "CIS 103";
            this.cis103CheckBox.UseVisualStyleBackColor = true;
            this.cis103CheckBox.CheckedChanged += new System.EventHandler(this.cis103CheckBox_CheckedChanged);
            // 
            // cis104CheckBox
            // 
            this.cis104CheckBox.AutoSize = true;
            this.cis104CheckBox.Location = new System.Drawing.Point(412, 212);
            this.cis104CheckBox.Name = "cis104CheckBox";
            this.cis104CheckBox.Size = new System.Drawing.Size(79, 21);
            this.cis104CheckBox.TabIndex = 11;
            this.cis104CheckBox.Text = "CIS 104";
            this.cis104CheckBox.UseVisualStyleBackColor = true;
            this.cis104CheckBox.CheckedChanged += new System.EventHandler(this.cis104CheckBox_CheckedChanged);
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Location = new System.Drawing.Point(572, 34);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(52, 17);
            this.scoresLabel.TabIndex = 12;
            this.scoresLabel.Text = "Scores";
            // 
            // score101TextBox
            // 
            this.score101TextBox.Location = new System.Drawing.Point(575, 73);
            this.score101TextBox.Name = "score101TextBox";
            this.score101TextBox.Size = new System.Drawing.Size(79, 22);
            this.score101TextBox.TabIndex = 13;
            this.score101TextBox.Visible = false;
            // 
            // score102TextBox
            // 
            this.score102TextBox.Location = new System.Drawing.Point(575, 116);
            this.score102TextBox.Name = "score102TextBox";
            this.score102TextBox.Size = new System.Drawing.Size(79, 22);
            this.score102TextBox.TabIndex = 14;
            this.score102TextBox.Visible = false;
            // 
            // score103TextBox
            // 
            this.score103TextBox.Location = new System.Drawing.Point(575, 166);
            this.score103TextBox.Name = "score103TextBox";
            this.score103TextBox.Size = new System.Drawing.Size(79, 22);
            this.score103TextBox.TabIndex = 15;
            this.score103TextBox.Visible = false;
            // 
            // score104TextBox
            // 
            this.score104TextBox.Location = new System.Drawing.Point(575, 212);
            this.score104TextBox.Name = "score104TextBox";
            this.score104TextBox.Size = new System.Drawing.Size(79, 22);
            this.score104TextBox.TabIndex = 16;
            this.score104TextBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(98, 347);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(137, 53);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(344, 295);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryTextBox.Size = new System.Drawing.Size(310, 105);
            this.summaryTextBox.TabIndex = 18;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(344, 268);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(67, 17);
            this.summaryLabel.TabIndex = 19;
            this.summaryLabel.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.score104TextBox);
            this.Controls.Add(this.score103TextBox);
            this.Controls.Add(this.score102TextBox);
            this.Controls.Add(this.score101TextBox);
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.cis104CheckBox);
            this.Controls.Add(this.cis103CheckBox);
            this.Controls.Add(this.cis102CheckBox);
            this.Controls.Add(this.cis101CheckBox);
            this.Controls.Add(this.coursesLabel);
            this.Controls.Add(this.majorGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.studnetIDTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Name = "Form1";
            this.Text = "Student Form Demo";
            this.majorGroupBox.ResumeLayout(false);
            this.majorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox studnetIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox majorGroupBox;
        private System.Windows.Forms.RadioButton ITRadioButton;
        private System.Windows.Forms.RadioButton webDesignRadioButton;
        private System.Windows.Forms.RadioButton programmingRadioButton;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.CheckBox cis101CheckBox;
        private System.Windows.Forms.CheckBox cis102CheckBox;
        private System.Windows.Forms.CheckBox cis103CheckBox;
        private System.Windows.Forms.CheckBox cis104CheckBox;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.TextBox score101TextBox;
        private System.Windows.Forms.TextBox score102TextBox;
        private System.Windows.Forms.TextBox score103TextBox;
        private System.Windows.Forms.TextBox score104TextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.Label summaryLabel;
    }
}

