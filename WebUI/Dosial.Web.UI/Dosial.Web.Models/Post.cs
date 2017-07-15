using Ouvera.Utilities.ModelTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosial.Web.Models 
{
    public class Post : ModelTracker
    {
        private int _id;
        private Guid _guid;
        private SecurityRole _securityRole;
        private DateTime _timestamp;
        private string _text;
        private byte[] _imageB64;

        public int id { get { return _id; } set { _id = value; } }
        public Guid guid { get { return _guid; } set { _guid = value; } }
        public SecurityRole securityRole { get { return _securityRole; } set { _securityRole = value; } }
        public DateTime timestamp { get { return _timestamp; } set { _timestamp = value; } }
        public string text { get { return _text; } set { _text = value; } }
        public byte[] imgB64 { get { return _imageB64; } set { _imageB64 = value; } }

    }
}
