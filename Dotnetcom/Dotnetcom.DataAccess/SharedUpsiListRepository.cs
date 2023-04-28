namespace Dotnetcom
{
    public class SharedUpsiListRepository : ISharedUpsiListRepository
    {
        private readonly DotnetcomContext _context;
        public SharedUpsiListRepository(DotnetcomContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SharedUpsiListModel>> GetAllAsync()
        {
            var sharedUpsiList = await _context.SharedUpsiLists.ToListAsync();
            return sharedUpsiList.Select(x => new SharedUpsiListModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Category = x.Category
            });
        }
        public async Task<SharedUpsiListModel> GetByIdAsync(int id)
        {
            var sharedUpsiList = await _context.SharedUpsiLists.FindAsync(id);
            return new SharedUpsiListModel
            {
                Id = sharedUpsiList.Id,
                Name = sharedUpsiList.Name,
                Description = sharedUpsiList.Description,
                Category = sharedUpsiList.Category
            };
        }
        public async Task<int> CreateAsync(SharedUpsiListModel model)
        {
            var sharedUpsiList = new SharedUpsiList
            {
                Name = model.Name,
                Description = model.Description,
                Category = model.Category
            };
            _context.SharedUpsiLists.Add(sharedUpsiList);
            await _context.SaveChangesAsync();
            return sharedUpsiList.Id;
        }
        public async Task UpdateAsync(SharedUpsiListModel model)
        {
            var sharedUpsiList = await _context.SharedUpsiLists.FindAsync(model.Id);
            sharedUpsiList.Name = model.Name;
            sharedUpsiList.Description = model.Description;
            sharedUpsiList.Category = model.Category;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var sharedUpsiList = await _context.SharedUpsiLists.FindAsync(id);
            _context.SharedUpsiLists.Remove(sharedUpsiList);
            await _context.SaveChangesAsync();
        }
    }
}