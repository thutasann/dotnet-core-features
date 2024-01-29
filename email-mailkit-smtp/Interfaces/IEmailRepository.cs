using System;
using System.Collections.Generic;
using email_mailkit_smtp.Dto;
namespace email_mailkit_smtp.Interfaces
{
    public interface IEmailRepository
    {
        void SendEmail(EmailDto emailDto);
    }
}