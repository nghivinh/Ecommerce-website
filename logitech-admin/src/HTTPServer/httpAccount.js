import axios from 'axios';

var domain="http://localhost:54015/api/IAccount/api/Account";

function callApi(endpoint, method='GET',body){
        return axios({
            method,
            url:`${domain}/${endpoint}`,
            data:body,
        }).catch(e=>{console.log(e)})
}
 
export function GET_ALL_ACCOUNT(endpoint){
    return callApi(endpoint,"GET");
}

export function GET_ACCOUNT(endpoint,id){
    return callApi(endpoint+"/"+id,"GET");
}

export function ADD_ACCOUNT(endpoint,data){
    return callApi(endpoint,"POST",data);
}
    
export function EDIT_ACCOUNT(endpoint,data){
    return callApi(endpoint,"PUT",data);
}

export function DELETE_ACCOUNT(endpoint){
    return callApi(endpoint,"DELETE");
}
