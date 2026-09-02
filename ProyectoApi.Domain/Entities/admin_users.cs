public class admin_users
{
    public int id { get; set; }
    public Guid uuid { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public string? password_hash { get; set; }
    public int role_id { get; set; }
    public bool is_active { get; set; }
    public DateTime last_login_at { get; set; }
    public DateTime created_at { get; set; }
    public string? refresh_token { get; set; }
    public DateTime expires_time { get; set; }
}