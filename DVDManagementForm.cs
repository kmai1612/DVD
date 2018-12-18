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
