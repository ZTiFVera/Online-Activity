using Online_Activity.ViewModel;

namespace Online_Activity.View
{
    public partial class StudentsView : ContentPage
    {
        public StudentsView()
        {
            InitializeComponent();
            // Set the binding context to the StudentsViewModel
            this.BindingContext = new StudentsViewModel();
        }
    }
}