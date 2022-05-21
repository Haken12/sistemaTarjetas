namespace sistemaTarjetas
{


    partial class dsDespachos
    {
        partial class DespachosDataTable
        { 
            public DespachosRow FindByCodigo(int codigo)
            {
                return (DespachosRow)this.Rows.Find(codigo);
            }

        }


    }
}
