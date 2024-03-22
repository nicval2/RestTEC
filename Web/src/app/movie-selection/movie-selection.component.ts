import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-movie-selection',
  templateUrl: './movie-selection.component.html',
  styleUrls: ['./movie-selection.component.css']
})
export class MovieSelectionComponent implements OnInit {

  constructor(){}

  ngOnInit(): void {
  }

  movies: string[] = [
    'https://cdn.discordapp.com/attachments/1017681477447712793/1154603143393452042/450_1000.jpg',
    'https://cdn.discordapp.com/attachments/1017681477447712793/1154603143628329062/e7b670c72cd5a8a683dc9f6c05db801e.jpg',
    'https://cdn.discordapp.com/attachments/1017681477447712793/1154603143875797022/JOKER-691x1024.jpg',
    'https://cdn.discordapp.com/attachments/1017681477447712793/1154603144249102336/LOS-IDUS-DE-MARZO.jpg',
    'https://cdn.discordapp.com/attachments/1017681477447712793/1154603144504942644/poster-peliculas-terror-2019-prodigy-1578395572.jpg'
  ];
  i : number = 0;

  chageImageR(){
    if(this.i == this.movies.length-1){
      this.i = 0;
    }else{
      this.i ++;
    }
  }

  chageImageL(){
    if(this.i == 0){
      this.i = this.movies.length-1;
    }else{
      this.i --;
    }
  }

}
