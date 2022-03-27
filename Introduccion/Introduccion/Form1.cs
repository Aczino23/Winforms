namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculos;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }
    
    private void InicializarComponentes()
    {
        // cambiar el tamaño de la ventana
        this.Size = new Size(300, 350);
        
        // Etiqueta figura
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10); // ubicacion
        
        // ComboBox de figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Location = new Point(10, 35); // ubicacion
        // valor por defecto
        cmbFiguras.SelectedIndex = 0;
        cmbFiguras.SelectedIndexChanged += new EventHandler(cmbFiguras_ValueChanged);
        
        // Etiqueta de calculo
        lblCalculo = new Label();
        lblCalculo.Text = "Calculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10); // ubicacion
        
        // ComboBox de calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.Location = new Point(150, 35); // ubicacion
        // valor por defecto
        cmbCalculos.SelectedIndex = 0;
        cmbCalculos.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);
        

        // Etiqueta de altura
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10, 80); // ubicacion

        // TextBox de altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100, 20);
        txtAltura.Location = new Point(60, 75); // ubicacion

        // Etiqueta de base
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10, 110); // ubicacion
        lblBase.Visible = false;
        
        // TextBox de base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 20);
        txtBase.Location = new Point(60, 105); // ubicacion
        txtBase.Visible = false;

        // Boton calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200); // ubicacion

        // Etiqueta resultado
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280); // ubicacion
        
        // TextBox resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(80, 275); // ubicacion

        // agregar los controles al formulario
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
    }
    
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculos.SelectedIndex.ToString();
        int altura = 0;
        if(txtAltura.Text != ""){
            altura = Convert.ToInt32(txtAltura.Text);
            txtResultado.Text=(altura*4).ToString();
        }
    }
    
    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras != null && cmbCalculos != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculos.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
            }
            else
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
            }
        }
    }
    
    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
        {
            lblResultado.Text = "Périmetro";
        }
        else
        {
            lblResultado.Text = "Área";
        }
    }
}