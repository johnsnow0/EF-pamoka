import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private router : Router) { }


  token = '';

  async prisijungti(data: any) {
    data.Id = 0
    data.Pastas = ""
    let atsakymasIsServerio = await fetch('https://localhost:7065/login', {
      method : 'POST',
      headers : {

        'Accept': 'application/json, text/plain, */*',

        'Content-Type': 'application/json'

      }, 
      body : JSON.stringify(data)
    })
    let tokenas = await atsakymasIsServerio.json().catch(error => {
      console.log(error)
      alert("Netinkamas slaptazodis")
    });

if (atsakymasIsServerio.status==401){
  alert("Netinkamas slaptazodis");
}

    if(tokenas != null && atsakymasIsServerio.status==200) {
      console.log(tokenas)
      this.router.navigate(['main'])
      
    }
  }
}
