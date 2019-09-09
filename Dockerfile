FROM devopsedu/webapp 
WORKDIR /var/www/html/
#COPY website dev/stage/prod/
#CMD ["rm -r *" ]
COPY website /var/www/html/
#FROM httpd:2.4
#WORKDIR /usr
#COPY ./dev/stage/prod/ ./usr/local/apache2/htdocs/
RUN echo "ServerName localhost" >> /etc/apache2/apache2.conf
#RUN echo "${APACHE_RUN_DIR} /usr/sbin/apache2"
#MD service apache2 start
#RUN echo "DocumentRoot dev/stage/prod/" >> /etc/apache1/apache2.conf
#EXPOSE 80 
#ENTRYPOINT /usr/sbin/service apache2 start

RUN a2enmod rewrite
RUN chown -R www-data:www-data /var/www

ENV APACHE_RUN_USER  www-data
ENV APACHE_RUN_GROUP www-data
ENV APACHE_LOG_DIR   /var/log/apache2
ENV APACHE_PID_FILE  /var/run/apache2/apache2.pid
ENV APACHE_RUN_DIR   /var/run/apache2
ENV APACHE_LOCK_DIR  /var/lock/apache2
ENV APACHE_LOG_DIR   /var/log/apache2

RUN mkdir -p $APACHE_RUN_DIR
RUN mkdir -p $APACHE_LOCK_DIR
RUN mkdir -p $APACHE_LOG_DIR

#COPY website /var/www

EXPOSE 80
#CMD ["/usr/sbin/apache2"]
CMD ["/usr/sbin/apache2", "-D",  "FOREGROUND"]


