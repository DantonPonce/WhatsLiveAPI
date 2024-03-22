using WhatsLiveAPI.Models;

namespace WhatsLiveAPI.DB {
    public static class UserFakeDb {
        public static readonly List<User> Users = new List<User>
        {
            new User(new Guid("fa3e8a17-b496-4083-be80-b8659e570a6a"), "Danton Ponce"),
            new User(new Guid("67742558-4d69-4a7a-8eda-8752ffc0fe8a"), "Harry Potter"),
            new User(new Guid("a2a8961c-b114-484a-a857-400390ec863c"), "Alvo Dumbledor"),
            new User(new Guid("3d4cbe06-ca22-4170-8aca-0b93982f141e"), "Lord Voldemort")
        };
    }
}
