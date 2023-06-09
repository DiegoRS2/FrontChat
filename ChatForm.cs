﻿using DevExpress.XtraBars;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontChat
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        const string hubAddress = "https://localhost:7065/chathub";

        public HubConnection Connection { get; set; }
        public FluentDesignForm1()
        {
            InitializeComponent();
            Connection = new HubConnectionBuilder().WithUrl(hubAddress).Build();

            Connection.Closed += HubConnection_Closed;

            gridControl1.DataSource = new List<Contato>()
            {
                new Contato(1, "Diego"),
                new Contato(2, "Gabriel"),
                new Contato(2, "GiovaniPietro")
            };


        }

        private async Task HubConnection_Closed(Exception? arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await Connection.StartAsync();
        }

        private async void FluentDesignForm1_Load(object sender, EventArgs e)
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

        private async void btnEnviar_Click(object sender, EventArgs e)
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
