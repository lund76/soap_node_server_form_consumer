namespace DemoDataConsumer
{
    public partial class Form1 : Form
    {
        SoapConsume.MyServicePortTypeClient serviceClient;
        public Form1()
        {
            InitializeComponent();
            serviceClient = new SoapConsume.MyServicePortTypeClient();      

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            var request = new SoapConsume.GetDataRequestBody(5);
            request.value = int.Parse(inputTxtBox.Text);

            var dataRequest = new SoapConsume.GetDataRequest(request);
            var response =  serviceClient.GetDataAsync(dataRequest).GetAwaiter().GetResult();

            resultistBox.Items.Add(response.Body.result.ToString());
        }
    }
}
