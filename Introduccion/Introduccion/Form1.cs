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
    Label? lblLado;
    TextBox? txtLado;
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
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10, 35); // ubicacion
        // valor por defecto
        cmbFiguras.SelectedIndex = 0;
        cmbFiguras.DropDownStyle = ComboBoxStyle.DropDownList;
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
        cmbCalculos.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCalculos.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);
        

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
        
        // Etiqueta de lado
        lblLado = new Label();
        lblLado.Text = "Lado";
        lblLado.AutoSize = true;
        lblLado.Location = new Point(10, 140); // ubicacion
        lblLado.Visible = false;
        
        // TextBox de lado
        txtLado = new TextBox();
        txtLado.Size = new Size(100, 20);
        txtLado.Location = new Point(60, 135); // ubicacion
        txtLado.Visible = false;
        
        // Boton calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200); // ubicacion
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

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
        this.Controls.Add(lblLado);
        this.Controls.Add(txtLado);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
    }
    
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculos.SelectedItem.ToString();
        string figura = cmbFiguras.SelectedItem.ToString();
        double resultado = 0;
        if (figura == "Cuadrado" && calculo == "Périmetro"){ // calcular el perimetro de un cuadrado
            try
            {
                double lado = Convert.ToDouble(txtAltura.Text);
                resultado = calcularPerimetroCuadrado(lado);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Text = "";
            }
        } 
        else if (figura == "Cuadrado" && calculo == "Área") // calcular el área de un cuadrado
        {
            try
            {
                double lado = Convert.ToDouble(txtAltura.Text);
                resultado = calcularAreaCuadrado(lado);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Text = "";
            }
        }
        else if (figura == "Rectangulo" && calculo == "Périmetro") // calcular périmetro del rectangulo
        {
            try
            {
                double baseR = Convert.ToDouble(txtBase.Text);
                double alturaR = Convert.ToDouble(txtAltura.Text);
                resultado = calcularPerimetroRectangulo(baseR, alturaR);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBase.Text = "";
                txtAltura.Text = "";
            }
        }
        else if (figura == "Rectangulo" && calculo == "Área")
        {
            try
            {
                double baseR = Convert.ToDouble(txtBase.Text);
                double alturaR = Convert.ToDouble(txtAltura.Text);
                resultado = calcularAreaRectangulo(baseR, alturaR);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBase.Text = "";
                txtAltura.Text = "";
            }
        }
        else if (figura == "Triangulo" && calculo == "Périmetro")
        {
            try
            {
                double baseT = Convert.ToDouble(txtBase.Text);
                double alturaT = Convert.ToDouble(txtAltura.Text);
                double ladoT = Convert.ToDouble(txtLado.Text);
                resultado = calcularPerimetroTriangulo(baseT, alturaT, ladoT);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBase.Text = "";
                txtAltura.Text = "";
                txtLado.Text = "";
            }
        }
        else if (figura == "Triangulo" && calculo == "Área")
        {
            try
            {
                double baseT = Convert.ToDouble(txtBase.Text);
                double alturaT = Convert.ToDouble(txtAltura.Text);
                resultado = calcularAreaTriangulo(baseT, alturaT);
                // mostrar resultado en el textbox de resultado
                txtResultado.TextAlign = HorizontalAlignment.Center;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBase.Text = "";
                txtAltura.Text = "";
            }
        }
        else
        {
            txtResultado.Text = "";
        }
    }

    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras != null && cmbCalculos != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && (cmbCalculos.SelectedItem.ToString() == "Périmetro" 
                || cmbCalculos.SelectedItem.ToString() == "Área"))
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblLado.Visible = false;
                txtLado.Visible = false;
                txtAltura.Text = "";
                txtBase.Text = "";
                txtLado.Text = "";
                txtResultado.Text = "";
            }
            else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculos.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblLado.Visible = false;
                txtLado.Visible = false;
                txtAltura.Text = "";
                txtBase.Text = "";
                txtLado.Text = "";
                txtResultado.Text = "";
            }
            else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculos.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblLado.Visible = true;
                txtLado.Visible = true;
                txtAltura.Text = "";
                txtBase.Text = "";
                txtLado.Text = "";
                txtResultado.Text = "";
            }
            else
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblLado.Visible = false;
                txtLado.Visible = false;
                txtAltura.Text = "";
                txtBase.Text = "";
                txtLado.Text = "";
                txtResultado.Text = "";
            }
        }
    }
    
   private double calcularAreaCuadrado(double lado){
        return lado * lado;
    }
   private double calcularAreaTriangulo(double altura, double lBase){
        return (altura * lBase) / 2;
    }
   
   private double calcularPerimetroCuadrado(double lado){
        return lado * 4;
    }

    private double calcularPerimetroTriangulo(double altura, double lBase, double lado){
        return altura + lBase + lado;
    }
    
    private double calcularAreaRectangulo(double baseR, double alturaR){
        return baseR * alturaR;
    }
    
    private double calcularPerimetroRectangulo(double baseR, double alturaR){
        return (baseR * 2) + (alturaR * 2);
    }
}