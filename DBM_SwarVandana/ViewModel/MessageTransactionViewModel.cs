using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ViewModel
{
    public class MessageTransactionViewModel:MessageTransaction
    {
        public MessageTransactionViewModel()
        { }

        public override long ID { get; set; }
        public override string MsgType { get; set; }
        public override long SendBy { get; set; }
        public override DateTime? SendDate { get; set; }
        public override string Message { get; set; }
        public override string SendTo { get; set; }
        public override bool IsBrodcast { get; set; }

        public MessageTransactionViewModel(MessageTransaction m)
        {
            this.ID = m.ID;
            this.MsgType = m.MsgType;
            this.SendBy = m.SendBy;
            this.SendDate = m.SendDate;
            this.Message = m.Message;
            this.SendTo = m.SendTo;
            this.IsBrodcast = m.IsBrodcast;
        }
    }
}