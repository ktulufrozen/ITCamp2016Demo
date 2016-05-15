import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

@inject(HttpClient)
export class App {
    
    constructor(httpClient) {
        this.message = "Hello Aurelia!";
        this.http = httpClient;
    }

    activate() {
        return this.http.get("/api/speakers")
            .then(response => {
                this.speakers = response.content;
            });
    }

}