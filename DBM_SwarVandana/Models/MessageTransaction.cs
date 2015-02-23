using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class MessageTransaction
    {
        public virtual long ID { get; set; }
        public virtual string MsgType { get; set; }
        public virtual long SendBy { get; set; }
        public virtual DateTime? SendDate { get; set; }
        public virtual string Message { get; set; }
        public virtual string SendTo { get; set; }
        public virtual bool IsBrodcast { get; set; }

        public MessageTransaction()
        {
            this.ID = 0;
            this.MsgType = string.Empty;
            this.SendBy = 0;
            this.SendDate = null;
            this.Message = string.Empty;
            this.SendTo = string.Empty;
            this.IsBrodcast = false;
        }
    }
}