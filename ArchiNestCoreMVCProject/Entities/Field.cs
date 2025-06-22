namespace ArchiNestCoreMVCProject.Entities
{
    public class Field
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public List<Team> Teams { get; set; }
    }
}
