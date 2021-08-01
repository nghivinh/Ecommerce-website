import axios from 'axios';

var domain="https://logitechdemo.azurewebsites.net/api/ICategory/api/Category";

function callApi(endpoint, method='GET',body){
        return axios({
            method,
            url:`${domain}/${endpoint}`,
            data:body,
        }).catch(e=>{console.log(e)})
}
 
export function GET_ALL_CATEGORIES(endpoint){
    return callApi(endpoint,"GET");
}

export function GET_CATEGORY(endpoint,id){
    return callApi(endpoint+"/"+id,"GET");
}

export function ADD_CATEGORY(endpoint,data){
    return callApi(endpoint,"POST",data);
}
    
export function EDIT_CATEGORY(endpoint,data){
    return callApi(endpoint,"PUT",data);
}

export function DELETE_CATEGORY(endpoint){
    return callApi(endpoint,"DELETE");
}
