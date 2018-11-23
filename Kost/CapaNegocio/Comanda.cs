using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Comanda
    {
        private int nroComanda;
        private DateTime fecha;
        private int nroMesa;
        private float total;
        private float descuento;
        private float precioFinal;
        private long cuilMozo;

        private bool error;
        private string mensaje;


        //Constructores
        public Comanda()
        {

        }

        public Comanda(int nroMesa, long cuilMozo, DateTime fechax)
        {
            Error = false;
            Mensaje = "";
            ComandaDeMesaActiva(nroMesa);
            if (!Error)
            {
                NroMesa = nroMesa;
                CuilMozo = cuilMozo;
                Fecha = fechax;
                Total = 0;
                Descuento = 0;
                PrecioFinal = 0;

                this.Guardar();
            }
            else
            {
                Error = true;
                Mensaje = "Ya existe una comanda activa para esta mesa";
            }
        }

        public Comanda(int nroC, DateTime fechax, int nroM, float tot, float desc, float precioF, long cuil)
        {
            Error = false;
            Mensaje = "";
            this.Validar(nroC, nroM);
            if (!Error)
            {
                NroComanda = nroC;
                NroMesa = NroMesa;
                CuilMozo = CuilMozo;
                Fecha = fechax;
                Total = tot;
                Descuento = desc;
                PrecioFinal = precioF;

                this.Guardar();
            }
            else
            {
                Error = true;
            }

        }


        //Getters y Setters
        public int NroComanda
        {
            get
            {
                return nroComanda;
            }

            set
            {
                nroComanda = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int NroMesa
        {
            get
            {
                return nroMesa;
            }

            set
            {
                nroMesa = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public float Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public float PrecioFinal
        {
            get
            {
                return precioFinal;
            }

            set
            {
                precioFinal = value;
            }
        }

        public long CuilMozo
        {
            get
            {
                return cuilMozo;
            }

            set
            {
                cuilMozo = value;
            }
        }

        public bool Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }
        
        
        //Funciones
        protected void Validar(int nroC, int nroMesa)
        {
            if(Validaciones.Comanda(nroC))
            {
                Error = true;
                Mensaje = "Ya existe una comanda con este número identificador";
            }
            if (Validaciones.ComandaDeMesaActiva(nroMesa)){
                Error = true;
                Mensaje = "Ya existe una comanda activa para esta mesa";
            }

        }

        protected void Guardar()
        {
            String msjGuardar = CapaDatos.ComandaBD.guardar(Fecha, NroMesa, CuilMozo);
            if (msjGuardar.Equals("OK"))
            {
                this.Error = false;
                this.Mensaje = "Comanda creada/guardada";
            }
            else
            {
                this.Error = true;
                this.Mensaje = msjGuardar;
            }
        }

        public static DataTable ComandasActivas()
        {
            return CapaDatos.ComandaBD.comandasActivas();
        }

        public Boolean ModificarComanda()
        {
            Error = false;
            Validar(NroComanda, NroMesa);

            if (!Error)
            {
                return CapaDatos.ComandaBD.modificar(NroMesa, CuilMozo, NroComanda);
            }
            else
            {
                return false;
            }

        }

        public static Boolean Eliminar(int nroComanda)
        {
            return CapaDatos.ComandaBD.eliminar(nroComanda);
        }

        public Boolean CerrarComanda()
        {
            return CapaDatos.ComandaBD.cerrarComanda(NroComanda, Total, Descuento, PrecioFinal);
        }

        public static Comanda TraerComanda(int nroComanda)
        {
            DataTable comand = CapaDatos.ComandaBD.traerUnaComanda(nroComanda);

            DataRow rowus = comand.Rows[0];

            Comanda com = new Comanda();

            com.NroComanda = Convert.ToInt32(rowus["nroComanda"].ToString());
            com.NroMesa = Convert.ToInt32(rowus["nroMesa"].ToString());
            com.PrecioFinal = float.Parse(rowus["precioFinal"].ToString());
            com.Total = float.Parse(rowus["total"].ToString());
            com.Fecha = Convert.ToDateTime(rowus["fecha"].ToString());
            com.Descuento = float.Parse(rowus["descuento"].ToString());
            com.CuilMozo = Convert.ToInt64(rowus["cuilMozo"].ToString());

            return com;
        }

        public static String NombreMozo(long cuil)
        {
            return CapaDatos.ComandaBD.nombreMozo(cuil);
        }

        public void ComandaDeMesaActiva(int nroM)
        {
            if (Validaciones.ComandaDeMesaActiva(nroM))
            {
                Error = true;
                Mensaje = "Ya existe una comanda activa para esta mesa";
            }
            else
            {
                Error = false;
            }
        }
    }
}