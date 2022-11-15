namespace MyTestWebApplication.Services
{
    public class PageService
    {
        private bool _isInitSelectPages;
        private IEnumerable<int> _selectPages;
        
        public IEnumerable<int> SelectPages
        {
            get
            {
                if (!_isInitSelectPages)
                    _selectPages = Enumerable.Range(1, 100); //Считывание из конфигурации (настройки)

                return _selectPages;
            }
        }
    }
}
