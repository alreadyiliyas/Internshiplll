#FROM указываем образ для запуска приложения в контейнере
FROM node:15.13-alpine
#Задает рабочую папку в контейнере
WORKDIR /app

COPY . .

RUN npm run build

CMD ["npm", "start"]
