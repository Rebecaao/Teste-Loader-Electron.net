namespace loader_thales.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Arquivo { get; set; }
        public int NPallet { get; set; }
        public int CaixaMaster { get; set; }
        public int CaixaMedia { get; set; }
        public int CaixaMini { get; set; }

        public int Unidades { get; set; }
    
    }
}