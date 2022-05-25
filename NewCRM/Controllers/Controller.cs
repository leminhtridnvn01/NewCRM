namespace NewCRM.Controllers
{
    public interface Controller<T>
    {
        // 1. Get list event
        public void OnGet();
        // 2. Get detail event
        public void OnDetails();
        // 3. Create event
        public void OnCreate();
        // 4. Update event
        public void OnUpdate();
        // 5. Delete event
        public void OnDelete();
    }
}
