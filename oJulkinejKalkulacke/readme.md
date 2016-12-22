# Julkina kalkulačka

Julka sa už od detstva rada hrá s číslami. Nedávno išla okolo jedného obchodu s elektronikou... no a odvtedy túži po namakanej kalkulačke, s ktorou by sa mohla do sýtosti zahrať. Keďže však všetky peniažky minula na kúpu pračky a nových okenných rámov, rozhodla si, že si takúto kalkulačku aspoň naprogramuje. Dokážete to aj vy?

## Vstup

Na vstupe je niekoľko riadkov, každý z nich predstavuje korektný úplne uzátvorkovaný aritmetický výraz. Korektné úplne uzátvorkované výrazy môžeme formálne definovať nasledovne:

každá číslica (0 až 9) je korektný výraz
ak X a Y sú korektné výrazy, tak aj (X+Y), (X-Y), (X*Y) a (X/Y) sú korektné výrazy
nič iné nie je korektný výraz
Znak / predstavuje celočíselné delenie. Môžete predpokladať, že pri vyhodnocovaní výrazov nikdy nebudete deliť nulou a že všetky medzivýsledky sa pohodlne zmestia do 32-bitových celočíselných premenných. Žiaden výraz nebude dlhší ako 50 znakov.

## Výstup

Pre každý výraz na vstupe vypíšte jeden riadok s jedným celým číslom – hodnotou daného výrazu.

## Príklad

### vstup      = vystup
((1+1)+(1+1))  = 4
(((5+5)/3)*3)  = 9
(1-2)          = -1