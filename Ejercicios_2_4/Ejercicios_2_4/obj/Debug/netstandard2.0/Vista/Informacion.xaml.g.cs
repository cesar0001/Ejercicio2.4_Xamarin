//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Ejercicios_2_4.Vista.Informacion.xaml", "Vista/Informacion.xaml", typeof(global::Ejercicios_2_4.Vista.Informacion))]

namespace Ejercicios_2_4.Vista {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Vista\\Informacion.xaml")]
    public partial class Informacion : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label nombre;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label descripcion;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xam.Forms.VideoPlayer.VideoPlayer videoPlayer;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Informacion));
            nombre = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "nombre");
            descripcion = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "descripcion");
            videoPlayer = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xam.Forms.VideoPlayer.VideoPlayer>(this, "videoPlayer");
        }
    }
}
