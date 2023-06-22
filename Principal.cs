using DevExpress.XtraEditors;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontChat
{
    public partial class Principal : DevExpress.XtraEditors.XtraForm
    {
        const string hubAddress = "https://localhost:7065/chathub";

        public HubConnection Connection { get; set; }
        public Principal()
        {
            InitializeComponent();
            Connection = new HubConnectionBuilder().WithUrl(hubAddress).Build();

            Connection.Closed += HubConnection_Closed;
        }

        private async Task HubConnection_Closed(Exception? arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await Connection.StartAsync();
        }

        private async void Principal_Load(object sender, EventArgs e)
        {
            Connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var newMessage = $"{user}:{message}";
                //listBox1.Items.Add(newMessage);
            });
            try
            {
                await Connection.StartAsync();
                //labelStatus.Text = "Conexão estabelecida com sucesso!!" ;
                //labelStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                //labelStatus.Text = ex.Message;
                //labelStatus.ForeColor = Color.Red;  
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                await Connection.InvokeAsync("SendMessage", "usuário", txtMenssagem.Text);
            }
            catch (Exception ex)
            {
                //listBox1.Items.Add(ex.Message);
            }

        }
    }
}