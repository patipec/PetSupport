export interface Message extends MessageNew{
  id: number;
  sendDate: string;
}
export interface MessageNew {
  clientId: number;
  petsitterId: number;
  message: string;
}

export interface MessageBrief{
  clientId: number;
  petsitterId: number;
  id: number;
  sendDate: string;
}
