import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

@inject(HttpClient)
export class SpeakerDetail {
    
    constructor(httpClient) {
        this.http = httpClient;
    }

    activate(params) {
                
        return this.http.get(`/api/speakers/${params.id}`)
            .then(response => {
                this.speaker = response.content;
            });
    }

}