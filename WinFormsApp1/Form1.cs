namespace WinFormsApp1;
using static cFiscale;

public partial class Form1 : Form
{

    cFiscale Funzione = new cFiscale();
    string cognome = "";
    string nome = "";
    string data = "";
    string sesso = "";
    string comune = "";
    string data2 = "";
    //string cognomeCode = "";
    //string nomeCode = "";
    //string dataCode = "";
    //string codiceFiscaleCompleto = "";

    public Form1()
    {
        // main
        InitializeComponent();

    }

    private void txtCognome_TextChanged(object sender, EventArgs e)
    {
        cognome = txtCognome.Text.ToUpper();
    }

    private void txtNome_TextChanged(object sender, EventArgs e)
    {
        nome = txtNome.Text.ToUpper();
    }

    private void txtData_TextChanged(object sender, EventArgs e)
    {
        // data = txtData.Text; vecchie caselle
    }

    private void txtBox_TextChanged(object sender, EventArgs e)
    {
        // sesso = txtSesso.Text; vecchie caselle
    }

    private void txtComune_TextChanged(object sender, EventArgs e)
    {
        comune = txtComune.Text.ToUpper();
    }

    private void btnCalcolo_Click(object sender, EventArgs e)
    {
        string cognomeCode = Funzione.calcoloCognome(cognome);
        string nomeCode = Funzione.calcoloNome(nome);
        string dataCode = Funzione.calcoloData(data2, sesso);
        string comuneCode = Funzione.calcoloComune(comune);

        string codiceFiscaleCompleto = cognomeCode + nomeCode + dataCode + comuneCode;

        string carattereControllo = Funzione.calcolaCarattereControllo(codiceFiscaleCompleto).ToString();

        codiceFiscaleCompleto = cognomeCode + nomeCode + dataCode + comuneCode + carattereControllo;

        lblOutput.Text = codiceFiscaleCompleto;
    }
    private void comboBoxSesso_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (comboBoxSesso.SelectedIndex == 0) // primo elemento scelta
        {
            sesso = "M";
        }
        else if (comboBoxSesso.SelectedIndex == 1) // secondo elemento scelta
        {
            sesso = "F";
        }
        else
        {
            sesso = comboBoxSesso.Text;
        }
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        dateTimePicker1.Format = DateTimePickerFormat.Custom; // per il formato di data personalizzato
        dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        data2 = dateTimePicker1.Text;
        lblDev.Text = data2;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        comboBoxSesso.SelectedItem = comboBoxSesso.Items[0];
        dateTimePicker1.Value = DateTime.Today;
    }
}

