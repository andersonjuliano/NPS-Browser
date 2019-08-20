# NPS-Browser
Projeto original: https://nopaystation.com/vita/npsReleases/

Release: 0.94


Novos funcionalidades:  
- no form principal
  - coloquei no form principal as funções que estavam anteriormente no "description panel"
  - inclui no datagridview os campos:
    - tamanho do jogo/DLC/Thema
    - lib - que indica se o jogo está na biblioteca
    - doubleclick no jogo irá abrir a pasta no windows explorer (somente jogos do vita)
  - alterei o nome pasta do jogos
    - jogos do vita, a pasta será o "nome do jogo [ID do jogo]"
    - jogos do PS3, irá criar uma pasta "nome do jogo [ID do jogo]", e dentro dessa pasta irá colocar uma pasta "packages" com pkgs e           outra pasta "exdata" com o RAP (quando necessário)
- na Libary
  - informação se um jogo tem DLC  
  - um segundo listview monstrando os jogos que já estão no vita (precisa configurar o caminho do vita)  
  - destaca em amarelo os jogos que estão no vita
  - novo botão para copiar os jogos da Libary para o vita  
  - novo botão para copiar as dlc da Libary para o vita
  - deixa ordenar a Libary por ID ou por nome  
