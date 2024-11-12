namespace ViajesBiblioteca
{
    public class PaqueteInicial : Paquete
    {
        public bool SalidasOpcional { get; set; }
      
        public PaqueteInicial(string H, string T, string C,bool salidaO) : base(H, T, C)
        {
            SalidasOpcional = salidaO;
        }
        
    }
}
