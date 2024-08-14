FROM node:22.6.0 as node
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build --prod

FROM nginx:1.27-alpine-perl
COPY --from=node /app/dist/receiptmate-web/browser /usr/share/nginx/html

EXPOSE 80