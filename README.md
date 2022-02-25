# Xamarin_Cross_Page_Binding
Xamarin Cross Page Binding with one ViewModel. Sync variables between pages. Global Xamarin Variables.

This project is an example for an idea that many have asked, but few have answered.  Binding between pages.

How do I have an `<Entry>` on one page where `Text="{Binding ThisPagesText}"` is entered on one page.

 ` <Entry x:Name="MainEntry" Text="{Binding ThisPagesText, Mode=TwoWay}"></Entry>
  <Label Text="{Binding ThisPagesText}" />`
  
  Then when the user navigates to another page - that pages'` <Entry> `or `<Label> `is updated with the value from the previous page.
  
   ` <Entry x:Name="SecondEntry" Text="{Binding ThisPagesText, Mode=TwoWay}"></Entry>
    <Label Text="{Binding ThisPagesText}" />`
  
  Yes - You can pass a variable beween pages with an Asnync event... However,  when you are updating some data from a database and you want all the views
  to have the new data from which was just loaded.  How do we do that.  
  
  This project uses two global like varialbes stored in the App.xaml.cs file.  
  Those two variables are accessed (get, and set) from one ViewModel.
  
  Two pages share the one ViewModel.  One problem arrises after the initial load - The "GET" for both variables only fires one time when the page is loaded.  
  
  I use the OnAppearing() method to re-bind all the Bindings. A total hack... I know - sorry.  This causes the Page to rebind and updates the views each time the page is viewed.
  Otherwise The variables GET wont be called and each page does not update the other.
  
  Let me know a better wat to do this - Thanks
  
