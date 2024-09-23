namespace Galeriya.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public string ImgUrl {  get; set; } //Image URL for storing Image
        public DateTime UploadPost { get; set; }
        public int UploadeyByUserId {  get; set; }
        public User UploadedBy {  get; set; } //Navigation Property

    }
}
