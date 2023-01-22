namespace Classical.Models
{
    public class Element
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Element()
        {
            Id=Guid.NewGuid().ToString();
        }
    }
}
