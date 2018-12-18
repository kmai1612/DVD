using System;
using System.Windows.Forms;

public class DVDManagementForm: Form
{
    private Button butAdd;
    private Label label1;
    private TextBox txtCatalog;
    private CheckBox chkForeign;
    private TextBox txtTitle;
    private Label label2;
    private ListBox lstDVDs;
    private TextBox txtLanguage;
    private Label label4;
    private TextBox txtRental;
    private Label label3;
    private Button btnClose;
	#region Windows Form Designer generated code
        
	private void InitializeComponent()
	{
            this.butAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.chkForeign = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDVDs = new System.Windows.Forms.ListBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRental = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(26, 116);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(71, 31);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalog#";
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(140, 19);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(100, 26);
            this.txtCatalog.TabIndex = 2;
            // 
            // chkForeign
            // 
            this.chkForeign.AutoSize = true;
            this.chkForeign.Location = new System.Drawing.Point(27, 79);
            this.chkForeign.Name = "chkForeign";
            this.chkForeign.Size = new System.Drawing.Size(89, 24);
            this.chkForeign.TabIndex = 3;
            this.chkForeign.Text = "Foreign";
            this.chkForeign.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(140, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(396, 26);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // lstDVDs
            // 
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.ItemHeight = 20;
            this.lstDVDs.Location = new System.Drawing.Point(25, 156);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(511, 84);
            this.lstDVDs.TabIndex = 10;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(235, 78);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(301, 26);
            this.txtLanguage.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Language:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(465, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 31);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRental
            // 
            this.txtRental.Location = new System.Drawing.Point(436, 19);
            this.txtRental.Name = "txtRental";
            this.txtRental.Size = new System.Drawing.Size(100, 26);
            this.txtRental.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Daily Rental ($):";
            // 
            // DVDManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(566, 251);
            this.Controls.Add(this.txtRental);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDVDs);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkForeign);
            this.Controls.Add(this.txtCatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAdd);
            this.Name = "DVDManagementForm";
            this.Text = "DVD Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

	}
    
	#endregion

	public static void Main()
	{
		DVDManagementForm main = new DVDManagementForm();
		Application.Run(main);
	}

	public DVDManagementForm()
	{
		InitializeComponent();
	}

    private void butAdd_Click(object sender, EventArgs e)
    {
        DVD dvd;
        try
        {
            if (chkForeign.Checked)
            {
                dvd = new ForeignDVD();
                ((ForeignDVD)dvd).Language = txtLanguage.Text;
            }
            else
            {
                dvd = new DVD();
            }
            dvd.CatalogNumber = int.Parse(txtCatalog.Text);
            dvd.Rental = decimal.Parse(txtRental.Text);
            dvd.Title = txtTitle.Text;
            lstDVDs.Items.Add(dvd);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
