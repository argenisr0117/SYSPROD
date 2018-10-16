using System;
using System.Collections.Generic;
using Datos;
using System.Data;

namespace Intermedia
{
    public class clsPonche
    {
        private clsManejador M = new clsManejador();


        #region Attributes

        int _Id;
        string _Ip;
        string _Name;
        int _Port;
        int _CmKey;
        bool _Status;

        ///////////////
        int _UserId;
        DateTime _Date;
        int _VerifyMode;
        #endregion

        #region Properties
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Ip
        {
            get { return _Ip; }
            set { _Ip = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Port
        {
            get { return _Port; }
            set { _Port = value; }
        }

        public int CmKey
        {
            get { return _CmKey; }
            set { _CmKey = value; }
        }

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        //////////////////////////
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public int VerifyMode
        {
            get { return _VerifyMode; }
            set { _VerifyMode = value; }
        }
        #endregion

        #region Methods

        public DataTable GetDeviceParams()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", _Id));
            return dt = M.Listado("obt_attdevice_params", lst);
        }

        public void InsertAtteandance()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@user_id", _UserId));
            lst.Add(new clsParametros("@date", _Date));
            lst.Add(new clsParametros("@verifymode", _VerifyMode));
            M.EjecutarSP("insert_attendance", ref lst);
            //mensaje = lst[2].Valor.ToString();
            //return mensaje;
        }


        #endregion
    }
}
