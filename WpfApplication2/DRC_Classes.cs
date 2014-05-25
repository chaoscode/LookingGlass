using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WpfApplication2
{
    class ServicePorts
    {
        public const int PORT_MSG = 50010;
        public const int PORT_VID = 50020;
        public const int PORT_AUD = 50021;
        public const int PORT_HID = 50022;
        public const int PORT_CMD = 50023;
    }

    class construct
    {
        public void BitField(string value, int length)
        {

        }

        public void Bit(string value)
        {

        }
    }

    class ServiceBaseType
    {
        public int seq_id_expect { get; set; }
        public string header_base { get; set; }
        public string header_aud { get; set; }
        public string header_msg { get; set; }
        public string header { get; set; }
    }

    class ServiceBase : Object
    {
        public void init (ServiceBaseType s)
        {
            s.seq_id_expect = 0;
        }

        public bool update_seq_id(ServiceBaseType s, int seq_id)
        {
            bool ret = true;
            if (s.seq_id_expect == 0)
            {
                s.seq_id_expect = seq_id;
            }
            else if (s.seq_id_expect != seq_id)
            {
                ret = false;
            }
            else
            {
                s.seq_id_expect = (seq_id + 1) & 0x3ff;
            }

            return ret;
        }

        public void close(ServiceBaseType s)
        {
            //pass
        }
    }

    class ASTRMBaseHeader
    {
        public bit fmt;
        public 
    }

    class  ServiceASTRM : ServiceBase
    {
        public void init(ServiceBaseType s)
        {
            base.init(s);
           // s.header_base = 
            
        }
    }
}
