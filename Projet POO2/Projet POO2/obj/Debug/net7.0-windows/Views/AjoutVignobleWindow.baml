   M S B A M L   `   `   `  ����F  BProjet POO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Projet_POO2.ViewsProjet_POO2.Views  5   	   +    %Projet_POO2.Views.AjoutVignobleWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Projet_POO2.Views     5   	     � Title$  AjoutVignobleWindow��5   	   $	��450��6%   $	��800��62   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $.��(Ajouter des informations sur le Vignoble��6   $��0��6D   $
��Bold"�6Q   $��16(�6c   $��Center=�6q   $
��0,10q�6�   �� 5   
   $��Surphace du Vignoble  :��6   $��1��62   $��10q�6?   �� 5   
   -   5         ��Name$ SurfaceVignoble��5   Y   $��1��6r   $��120,10,10,10q�6   ��6   �� *Vignoble.Surface+ �� UpdateSourceTrigger$ PropertyChanged=�6   �� 5   
   $��Emplacement :��6   $��3��6(   $��10q�65   �� 5   
   -   5        $ Emplacement��5   ]   $��3��6r   $��120,10,10,10q�6   ��6   �� *Vignoble.Emplacement+$ PropertyChanged=�6   �� 5   
   $��ID Poprietaire :��6   $��4��6+   $��10q�68   �� 5    
   -   5        $ IdProprietaire��5    h   $��4��6�   $��120,10,10,10q�6�   ��6   �� *!Vignoble.IdProprietaireVignoble+$ PropertyChanged=�6�   �� 5"   
   $��ID Terrain:��6   $��5��6&   $��10q�63   �� 5#   
   -   5        $ 	IdTerrain��5#   [   $��5��6n   $��120,10,10,10q�6{   ��6   �� *Vignoble.IdTerrain+$ PropertyChanged=�6{   �� 5&   
    �� Orientation$ 
Horizontal=�6   $��8��6.   $��Center=�6;   $
��0,20q�6X   .+�5'      �� $��OK��6   $	��100��6"   $��10q�6.   ��6;   �� *VignobleCommand+�� 5(      -   5        $��Annuler��5(      $	��100��6'   $��10q�63   6?   5)      5*      5+      