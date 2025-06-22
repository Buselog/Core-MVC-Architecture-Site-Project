namespace ArchiNestCoreMVCProject.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string  ImageUrl { get; set; }
        public int FieldId { get; set; }
        public Field Field { get; set; }
    }

}
