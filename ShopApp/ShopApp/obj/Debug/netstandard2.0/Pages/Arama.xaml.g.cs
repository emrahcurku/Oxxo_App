//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("ShopApp.Pages.Arama.xaml", "Pages/Arama.xaml", typeof(global::ShopApp.Pages.Arama))]

namespace ShopApp.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\Arama.xaml")]
    public partial class Arama : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Plugin.InputKit.Shared.Controls.AdvancedEntry searchbar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.CollectionView aramaListe;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Arama));
            searchbar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Plugin.InputKit.Shared.Controls.AdvancedEntry>(this, "searchbar");
            aramaListe = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CollectionView>(this, "aramaListe");
        }
    }
}
