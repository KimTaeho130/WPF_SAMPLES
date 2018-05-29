using System.Windows;
using System.Windows.Controls;

namespace WPF_MVVM_SAMPLE01
{
    public class SubjectSelectDataTemplate : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Score score = item as Score;
            FrameworkElement el = container as FrameworkElement;
            return (DataTemplate)el.FindResource(score.SCORE > 60 ? "DataTemplate3" : "DataTemplate4");
        }
    }
}
