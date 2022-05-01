namespace ListViewExample
{
    public class Champs
    {
        public string Rol { get; set; }
        public string Daño { get; set; }
        public string DisplayName
        {
            get
            {
                return $" rol :{Rol}, \n daño :{Daño}";
            }
        }
    }
}