#O šírení klebiet

Časový limit:	5000 ms
Pamäťový limit:	265 MB

Bolo raz jedno KSP alebo tiež Klebetná Spoločnosť Programátorov. Ako iste vieš, KSP už má svoje roky, takže nepozná každý každého. Ak sa ale niekto dozvie nejakú klebetu, ihneď ju vedia aj všetci, ktorých tento človek pozná. Naša databáza presne vie, kto koho pozná. My by sme radi vedeli, či sa klebeta dokáže rozšíriť po celom KSP.

##Vstup

Na prvom riadku vstupu sa nachádza jedno prirodzené číslo N (1 ≤ N ≤ 100) – počet KSPákov. Ďalších N riadkov obsahuje mená KSPákov. Každé meno je reťazec veľkých a malých písmen anglickej abecedy, dĺžky mien sú medzi 1 a 20 vrátane. V nasledujúcom riadku je jedno celé číslo M – počet známostí v KSP. Nasleduje M riadkov. V každom z týchto riadkov sú uvedené mená dvoch KSPákov, ktorí sa navzájom poznajú. Medzi menami je práve 1 medzera. Môžete predpokladať, že každá dvojica ľudí sa v tomto zozname vyskytuje najviac raz.

##Výstup

Tvoj program by mal vypísať jediný riadok obsahujúci slovo "ANO", ak sa každá klebeta rozšíri po celom KSP, alebo "NIE", ak tomu tak nie je.

##Príklad 1

###vstup
5
Julka
Misof
Monika
Palo
YoYo
4
Julka YoYo
YoYo Misof
Misof Julka
Palo Monika

###výstup
NIE

##Príklad 2

###vstup
5
Julka
Misof
Monika
Palo
YoYo
5
Julka YoYo
YoYo Misof
Misof Julka
Palo Monika
Misof Monika

###výstup
ANO

## Vysvetlenie

V prvom príklade vstupu a výstupu sa klebety, ktoré vie Julka, k Paľovi a Monike nijako nedostanú, preto je odpoveď NIE.