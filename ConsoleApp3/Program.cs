using LolClasses;

//stwórz nowego champa - garena
Garen g = new Garen();
//opdal emotke dla garena
g.ctrl3();

//stworz instacje przedmiotu - rubycrystal
RubyCrystal rb = new RubyCrystal();
//sprawdz ile ma hp garen
WizardWand ww = new WizardWand();
g.showHP();
//kup mu item
g.buyItem(rb);
//sprawdz ile ma teraz hp
g.showHP();
//kup mu drugi item
g.buyItem(rb);
//sprawdz ile ma teraz hp
g.showHP();
//sprawdz ile ma teraz ad
g.showAD();
//sprawdz ile ma teraz ap
g.showAP();
//kup mu trzeci item
g.buyItem(ww);
//sprawdz ile ma teraz hp
g.showHP();
//sprawdz ile ma teraz ad
g.showAD();
//sprawdz ile ma teraz ap
g.showAP();






