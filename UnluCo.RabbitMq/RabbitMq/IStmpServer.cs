﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Application.RabbitMq
{
    public interface IStmpServer
    {
        SmtpClient GetSmtpClient();
    }
}
