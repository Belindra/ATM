Ohjelma on konsolissa toimiva pankkiautomaattisimulaattori, jonka k‰yttˆkielen‰ on englanti. Ohjelman koodasivat Gian Villanueva, Sirene Karri ja Anniina Aarnio.

1.	Ohjelma pyytt‰‰ k‰ytt‰j‰‰ laittamaan k‰ytt‰j‰tunnuksen
2.	Jos k‰ytt‰j‰tunnus on v‰‰rin, ohjelma pyyt‰‰ laittamaan sen uudelleen
3.	Jos k‰ytt‰j‰tunnus on oikein, ohjelma siirtyy kohtaan 5
4.	Jos k‰ytt‰j‰ laittaa k‰ytt‰j‰tunnuksen 3 kertaa v‰‰rin, ohjelma tulostaa virheilmoituksen ja loppuu
5.	Ohjelma pyyt‰‰ k‰ytt‰j‰‰ laittamaan pin koodin
6.	Jos k‰ytt‰j‰n laittama pin koodi on oikein, ohjelma jatkaa eteenp‰in valikkoon tarkista saldo/nosta rahaa/vaihda pin koodi/tallenna rahaa/lopeta
7.	Jos k‰ytt‰j‰n antama pin koodin on v‰‰rin, ohjelma siirtyy kohtaan 13
8.	Ohjelma siirtyy valikkoon, jossa ensimm‰isen‰ vaihtoehtona k‰ytt‰j‰ voi tarkistaa tilin saldon
9.	Toisena vaihtoehtona k‰ytt‰j‰ voi nostaa tililt‰‰n rahaa
10.	Kolmantena valikkovaihtoehtona on vaihtaa pin koodi
11.	Nelj‰nten‰ vaihtoehtona valikossa on tallentaa rahaa
12.	Viidenten‰ valikkovaihtoehtona on ohjelman lopetus
13.	Jos k‰ytt‰j‰ laittaa pin koodin ohjelman alussa v‰‰rin, pyyt‰‰ ohjelma laittamaan sen uudestaan. Jos pin koodi laitetaan kolme kertaa v‰‰rin, ohjelma loppuu ja ilmoittaa lukinneensa k‰ytt‰j‰n kortin
14.	Jos k‰ytt‰j‰ valitsee saldon tarkastamisen, printtaa ohjelma k‰ytt‰j‰n saldon ja palaa takaisin valikkoon
15.	Jos k‰ytt‰j‰ haluaa nostaa rahaa, kysyy ohjelma summaa, jonka k‰ytt‰j‰ haluaa nostaa
16.	 K‰ytt‰j‰n halutessa vaihtaa pin koodi, pyyt‰‰ ohjelma ensin vanhan pin koodin
17.	K‰ytt‰j‰n halutessa tallettaa rahaa, kysyy ohjelma, kuinka paljon rahaa k‰ytt‰j‰ haluaa tallentaa
18.	Valikon lopeta kohta lopettaa ohjelman
19.	Jos k‰ytt‰j‰ yritt‰‰ rahaa nostaessa valita negatiivisen arvon, siirtyy ohjelma eteenp‰in kohtaan 25
20.	Jos k‰ytt‰j‰ yritt‰‰ nostaa tililt‰ enemm‰n rahaa kuin tilill‰ on katetta, siirtyy ohjelma eteenp‰in kohtaan 26
21.	Ohjelma kysyy, haluaako k‰ytt‰j‰ tulostaa kuitin
22.	K‰ytt‰j‰n vaihtaessa uutta pin koodia ohjelma pyyt‰‰ laittamaan uuden pin koodin ja ilmoittaa, ett‰ pin koodi on vaihdettu
23.	Vaihdettaessa pin koodia, jos k‰ytt‰j‰ laittaa vanhan pin koodin v‰‰rin, pyyt‰‰ ohjelma laittamaan koodin uudelleen
24.	Tallettaessa rahaa, ohjelma ilmoittaa k‰ytt‰j‰lle summan, joka talletettiin sek‰ tilin sen hetkisen saldon
25.	K‰ytt‰j‰n yritt‰ess‰ laittaa negatiivisen arvon rahaa nostaessa, ohjelma ilmoittaa hyv‰ksyv‰ns‰ vain positiivisen arvon ja ohjelma palaa takaisin valikkoon 
26.	K‰ytt‰j‰n yritt‰ess‰ nostaa enemm‰n rahaa, kuin tilill‰ on katetta ilmoittaa ohjelma, ettei t‰m‰ onnistu ja k‰ytt‰j‰‰ pyydet‰‰n poistamaan pankkikortti
27.	Jos k‰ytt‰j‰ haluaa tulostaa kuitin, siirtyy ohjelma eteenp‰in kohtaan 29
28.	Jos k‰ytt‰j‰ ei halua tulostaa kuittia, siirtyy ohjelma eteenp‰in kohtaan 30
29.	Halutessaan tulostaa kuitin, ohjelma printtaa n‰kyviin k‰ytt‰j‰n nostaman rahasumman sek‰ tilille j‰‰v‰n saldon
30.	Jos k‰ytt‰j‰ ei halunnut tulostaa kuittia, ohjelma pyyt‰‰ k‰ytt‰j‰‰ ottamaan rahat ja poistamaan pankkikorttinsa